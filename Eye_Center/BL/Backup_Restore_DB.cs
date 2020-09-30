using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Eye_Center.BL
{
    class Backup_Restore_DB
    {

        // The Query In SQL Server
        /*
            BACKUP DATABASE [data] TO  DISK = N'C:\Backup\data.bak' WITH NOFORMAT, NOINIT,  NAME = N'data-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10
            GO

            RESTORE DATABASE [data] FROM  DISK = N'C:\Backup\data.bak' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 10
            GO
        */

        // _connectionString = @"Server=.\; Integrated Security = true";
        private readonly string _connectionString;

        // var to Backup
        private readonly string[] _systemDatabaseNames = { "master", "tempdb", "model", "msdb", "ReportServer", "ReportServerTempDB" };
        

        public Backup_Restore_DB(string connectionString)
        {
            // connectionString = @"Server=.\; Integrated Security = true";

            _connectionString = connectionString;
            // _FolderORFileFullPath = FolderORFileFullPath;
        }

        public string BackupAllDatabases(string BackupFolderPath)
        {
            foreach (string databaseName in GetAllDatabasesNames())
            {
                if(databaseName.Contains("ERROR"))
                {
                    return databaseName;
                }
                string result = BackupDatabase(databaseName, BackupFolderPath);
                if (!result.Equals(""))
                    return result;
            }

            return "";
        }

        public string BackupDatabase(string databaseName, string BackupFolderPath)
        {
            try
            {
                string filePath = BuildFileNameBYBackupPathWithDatabaseName(databaseName, BackupFolderPath);

                using (var connection = new SqlConnection(_connectionString))
                {
                    var query = String.Format("BACKUP DATABASE [{0}] TO DISK = N'{1}' WITH NAME = N'Backup-Full of {0} Database in {1}' ", databaseName, filePath);

                    using (var command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }

                return "";
            }
            catch(Exception ex)
            {
                return "ERROR : " + ex.Message;
            }
        }

        public string RestoreDatabase(string databaseName, string RestoreFilePath)
        {
            // string databaseName = GetDatabaseNameFromFileThatWantToRestore(RestoreFilePath);
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    var query = "USE master";
                    new SqlCommand(query, connection).ExecuteNonQuery();

                    if (IsDatabaseExist(databaseName))
                    {
                        // This rollback any transaction which is running on that database and brings SQL Server database in a single user mode.
                        query = String.Format("ALTER DATABASE [{0}] SET Single_User WITH Rollback Immediate", databaseName);
                        new SqlCommand(query, connection).ExecuteNonQuery();
                    }

                    // The below query will restore database file from disk where backup was taken ....
                    query = String.Format("RESTORE DATABASE [{0}] FROM  DISK = N'{1}' WITH FILE = 1, REPLACE, NOUNLOAD, STATS = 10 ", databaseName, RestoreFilePath);
                    new SqlCommand(query, connection).ExecuteNonQuery();

                    if (IsDatabaseExist(databaseName))
                    {
                        // the below query change the database back to multiuser
                        query = String.Format("ALTER DATABASE [{0}] SET Multi_User", databaseName);
                        new SqlCommand(query, connection).ExecuteNonQuery();
                    }

                    connection.Close();
                }

                return "";
            }
            catch(Exception ex)
            {
                return "ERROR : " + ex.Message;
            }

        }

        /// <summary>
        /// Get or Split Database Name From File Name
        /// </summary>
        /// <param name="filePath">The Full path Of File To Restore</param>
        /// <param name="charSplitDBNameAndOtherTextInFileName">Character That Split DatabaseName From Other Text In FileName Of File That Want To Restore It. the default is - </param>
        /// <returns>Database Name</returns>
        public string GetDatabaseNameFromFileThatWantToRestore(string filePath, char charSplitDBNameAndOtherTextInFileName = '-')
        {
            try
            {
                string[] paths = filePath.Split('\\');
                string[] fileNames = paths[(paths.Length - 1)].Split(charSplitDBNameAndOtherTextInFileName);
                return fileNames[0];
            }
            catch (Exception ex)
            {
                return "ERROR : " + ex.Message;
            }
        }





        private string BuildFileNameBYBackupPathWithDatabaseName(string databaseName, string BackupFolderPath)
        {
            // string filename = string.Format("{0}-{1}.bak", databaseName, DateTime.Now.ToString("yyyy-MM-dd"));
            string filename = string.Format("{0}--{1}.sql", databaseName, DateTime.Now.ToString("yyyy_MM_dd___h_mm_ss_tt"));

            return Path.Combine(BackupFolderPath, filename);
        }

        private IEnumerable<string> GetAllDatabasesNames()
        {
            var databases = new List<String>();

            try
            {

                DataTable databasesTable;

                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    databasesTable = connection.GetSchema("Databases");

                    connection.Close();
                }

                foreach (DataRow row in databasesTable.Rows)
                {
                    string databaseName = row["database_name"].ToString();

                    if (_systemDatabaseNames.Contains(databaseName))
                        continue;

                    databases.Add(databaseName);
                }

            }
            catch(Exception ex)
            {
                databases.Add("ERROR : " + ex.Message);
            }

            return databases;
        }

        private bool IsDatabaseExist(string databaseName)
        {
            DataTable databasesTable;

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                databasesTable = connection.GetSchema("Databases");

                connection.Close();
            }

            foreach (DataRow row in databasesTable.Rows)
            {
                string _databaseName = row["database_name"].ToString();
                
                if (_databaseName.Equals(databaseName))
                    return true;
            }

            return false;
        }
    }
}
