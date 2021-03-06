USE [master]
GO
/****** Object:  Database [Eye_Center]    Script Date: 9/23/2020 6:36:30 AM ******/
CREATE DATABASE [Eye_Center]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Eye_Center', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Eye_Center.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Eye_Center_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Eye_Center_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Eye_Center] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Eye_Center].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Eye_Center] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Eye_Center] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Eye_Center] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Eye_Center] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Eye_Center] SET ARITHABORT OFF 
GO
ALTER DATABASE [Eye_Center] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Eye_Center] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Eye_Center] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Eye_Center] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Eye_Center] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Eye_Center] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Eye_Center] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Eye_Center] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Eye_Center] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Eye_Center] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Eye_Center] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Eye_Center] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Eye_Center] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Eye_Center] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Eye_Center] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Eye_Center] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Eye_Center] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Eye_Center] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Eye_Center] SET  MULTI_USER 
GO
ALTER DATABASE [Eye_Center] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Eye_Center] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Eye_Center] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Eye_Center] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Eye_Center] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Eye_Center] SET QUERY_STORE = OFF
GO
USE [Eye_Center]
GO
/****** Object:  User [wadee1]    Script Date: 9/23/2020 6:36:31 AM ******/
CREATE USER [wadee1] FOR LOGIN [wadee1] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [wadee]    Script Date: 9/23/2020 6:36:31 AM ******/
CREATE USER [wadee] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [admin]    Script Date: 9/23/2020 6:36:31 AM ******/
CREATE USER [admin] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [wadee1]
GO
ALTER ROLE [db_owner] ADD MEMBER [wadee]
GO
ALTER ROLE [db_owner] ADD MEMBER [admin]
GO
/****** Object:  Table [dbo].[Biometry]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Biometry](
	[BiometryID] [int] NOT NULL,
	[OD_or_OS] [text] NOT NULL,
	[K1] [text] NULL,
	[K2] [text] NULL,
	[Axial_length] [text] NULL,
	[A_Constant] [text] NULL,
	[AC_and_IOL] [text] NULL,
	[PC_and_IOL] [text] NULL,
	[B_Scan] [text] NULL,
	[Patient_id] [int] NOT NULL,
	[User_id] [int] NOT NULL,
	[NoFile] [int] NOT NULL,
	[Note1] [text] NULL,
	[Note2] [text] NULL,
 CONSTRAINT [PK_Biometry] PRIMARY KEY CLUSTERED 
(
	[BiometryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bond_Book]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bond_Book](
	[BondNumber] [int] NOT NULL,
	[BondNumType] [int] NOT NULL,
	[Patient_id] [int] NOT NULL,
	[User_id] [int] NOT NULL,
	[BondAmount] [float] NOT NULL,
	[BondDiscount] [float] NOT NULL,
	[BondCash_or_After] [nvarchar](10) NOT NULL,
	[BondDate] [datetime] NOT NULL,
	[BondState] [nvarchar](50) NOT NULL,
	[col1] [nvarchar](50) NULL,
	[col2] [nvarchar](50) NULL,
 CONSTRAINT [PK_Bond_Book] PRIMARY KEY CLUSTERED 
(
	[BondNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bond_Book_Type]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bond_Book_Type](
	[Bond_Name] [nvarchar](100) NOT NULL,
	[Bond_Number] [int] NOT NULL,
	[Bond_Code] [nvarchar](100) NOT NULL,
	[col1] [nvarchar](50) NULL,
	[col2] [nvarchar](50) NULL,
 CONSTRAINT [PK_Bond_Book_Type] PRIMARY KEY CLUSTERED 
(
	[Bond_Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Checked_Patient]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Checked_Patient](
	[Checked_PatientID] [int] NOT NULL,
	[L_or_R_Eye] [char](1) NULL,
	[Present_Complaint] [text] NULL,
	[Previous_Ocular_History] [text] NULL,
	[Using_any_Medicine] [text] NULL,
	[Any_Sensitivity] [text] NULL,
	[Ocular_motility] [text] NULL,
	[Slit_lamp_Examination] [text] NULL,
	[Eyelids] [text] NULL,
	[Cornea] [text] NULL,
	[AC] [text] NULL,
	[Lens] [text] NULL,
	[Vitreous] [text] NULL,
	[Fundus] [text] NULL,
	[Gonioscopy] [text] NULL,
	[UltraSound] [text] NULL,
	[Treatment] [text] NULL,
	[User_id] [int] NOT NULL,
	[Patient_id] [int] NOT NULL,
	[NoFile] [int] NOT NULL,
	[Note1] [text] NULL,
	[Note2] [text] NULL,
 CONSTRAINT [PK_Checked_Patient] PRIMARY KEY CLUSTERED 
(
	[Checked_PatientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clinic]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clinic](
	[Name] [nchar](50) NOT NULL,
	[Clinic_id] [int] NOT NULL,
	[Shift] [nchar](20) NOT NULL,
	[User_id] [int] NOT NULL,
	[Note1] [text] NULL,
	[Note2] [text] NULL,
 CONSTRAINT [PK_Clinic] PRIMARY KEY CLUSTERED 
(
	[Clinic_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Deleted_Bond_Book]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deleted_Bond_Book](
	[BondNumber] [int] NOT NULL,
	[BondNumType] [int] NOT NULL,
	[Patient_id] [int] NOT NULL,
	[User_id] [int] NOT NULL,
	[BondAmount] [float] NOT NULL,
	[BondDiscount] [float] NOT NULL,
	[BondCash_or_After] [nvarchar](10) NOT NULL,
	[BondDate] [datetime] NOT NULL,
	[BondState] [nvarchar](50) NOT NULL,
	[col1] [nvarchar](50) NULL,
	[col2] [nvarchar](50) NULL,
 CONSTRAINT [Bond_Book_Deleted] PRIMARY KEY CLUSTERED 
(
	[BondNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Follow_up]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Follow_up](
	[FollowUpID] [int] NOT NULL,
	[NoFile] [int] NOT NULL,
	[Patient_id] [int] NOT NULL,
	[Date] [datetime] NULL,
	[Result] [text] NULL,
	[Treatment] [text] NULL,
	[User_id] [int] NOT NULL,
	[Note1] [text] NULL,
	[Note2] [text] NULL,
 CONSTRAINT [PK_Follow_up] PRIMARY KEY CLUSTERED 
(
	[FollowUpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Global_Narcosis]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Global_Narcosis](
	[NoFile] [int] NOT NULL,
	[Urea_and_creation] [text] NULL,
	[BT_and_CT] [text] NULL,
	[Liver_functor_test] [text] NULL,
	[ECG] [text] NULL,
	[C_X_ray] [text] NULL,
	[Medical] [text] NULL,
	[ENT_Dr] [text] NULL,
	[pediatric] [text] NULL,
	[Surgery_id] [int] NOT NULL,
	[CBC] [text] NULL,
	[BS] [text] NULL,
	[Note1] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lists]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lists](
	[ListID] [int] NOT NULL,
	[ListName] [nvarchar](30) NULL,
 CONSTRAINT [PK_Lists] PRIMARY KEY CLUSTERED 
(
	[ListID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Local_Narcosis]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Local_Narcosis](
	[NoFile] [int] NOT NULL,
	[BP] [text] NULL,
	[Viral_Marks_and_HIV] [text] NULL,
	[Surgery_id] [int] NOT NULL,
	[CBC] [text] NULL,
	[BS] [text] NULL,
	[Note1] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[Name] [nvarchar](100) NOT NULL,
	[Patient_id] [int] NOT NULL,
	[Date] [datetime] NULL,
	[Address] [text] NOT NULL,
	[No_File] [int] NOT NULL,
	[Phone] [nvarchar](50) NULL,
	[Age] [nvarchar](50) NOT NULL,
	[User_id] [int] NOT NULL,
	[Clinic_id] [int] NOT NULL,
	[Sex] [nvarchar](50) NULL,
	[Note1] [text] NULL,
	[Note2] [text] NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[Patient_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Post_Operative_Follow_up]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Post_Operative_Follow_up](
	[Post_Oper_FollowID] [int] NOT NULL,
	[Surgery_id] [int] NOT NULL,
	[Patient_id] [int] NOT NULL,
	[NoFile] [int] NOT NULL,
	[VA] [text] NULL,
	[PH] [text] NULL,
	[Date] [datetime] NULL,
	[Astigmatism] [text] NULL,
	[Corneal_Cause] [text] NULL,
	[Corneal_Opacity] [text] NULL,
	[C_Odema] [text] NULL,
	[Retinal_Disease] [text] NULL,
	[Glaucoma] [text] NULL,
	[Others] [text] NULL,
	[User_id] [int] NOT NULL,
	[Note1] [text] NULL,
 CONSTRAINT [PK_Post_Operative_Follow_up] PRIMARY KEY CLUSTERED 
(
	[Post_Oper_FollowID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Priv]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Priv](
	[UserID] [int] NOT NULL,
	[ScreenID] [int] NOT NULL,
	[View] [bit] NULL,
	[Add] [bit] NULL,
	[Update] [bit] NULL,
	[Print] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Routine_Check]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Routine_Check](
	[RoutineCheckID] [int] NOT NULL,
	[D_or_N] [text] NULL,
	[VA] [text] NULL,
	[With_Glasses] [text] NULL,
	[PH] [text] NULL,
	[IOP] [text] NULL,
	[Shp] [text] NULL,
	[Cyl] [text] NULL,
	[Axis] [text] NULL,
	[ShpAuto] [text] NULL,
	[CylAuto] [text] NULL,
	[AxisAuto] [text] NULL,
	[OD_or_OS] [text] NULL,
	[Patient_id] [int] NOT NULL,
	[NoFile] [int] NOT NULL,
	[User_id] [int] NOT NULL,
	[Note1] [text] NULL,
 CONSTRAINT [PK_Routine_Check] PRIMARY KEY CLUSTERED 
(
	[RoutineCheckID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Screens]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Screens](
	[ScreenID] [int] NOT NULL,
	[ScreenName] [nvarchar](30) NULL,
	[ListID] [int] NULL,
 CONSTRAINT [PK_Scteens] PRIMARY KEY CLUSTERED 
(
	[ScreenID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Surgery]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Surgery](
	[Surgery_id] [int] NOT NULL,
	[Patient_id] [int] NOT NULL,
	[NoFile] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Place] [text] NOT NULL,
	[Type] [text] NOT NULL,
	[L_or_R_Eye] [char](1) NOT NULL,
	[Admit_For] [text] NULL,
	[Narcosis] [text] NOT NULL,
	[Treatment] [text] NULL,
	[User_id] [int] NOT NULL,
	[Axial_Length] [text] NULL,
	[IoI_Power] [text] NULL,
	[Blood_Pressure] [text] NULL,
	[Blood_Sugar] [text] NULL,
	[Name_Assistant] [text] NULL,
 CONSTRAINT [PK_Surgery] PRIMARY KEY CLUSTERED 
(
	[Surgery_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SurgeryPrices]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SurgeryPrices](
	[SurgeryPrice_id] [int] NULL,
	[SurgeryPrice_code] [varchar](50) NULL,
	[SurgeryPrice] [int] NULL,
	[SurgeryPrice_name] [varchar](50) NULL,
	[SurgeryPrice_note] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[System_Record]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[System_Record](
	[Time] [time](7) NULL,
	[Date] [datetime] NULL,
	[Operation] [text] NULL,
	[User_id] [int] NOT NULL,
	[Note1] [text] NULL,
	[Note2] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Name] [nvarchar](100) NOT NULL,
	[User_id] [int] NOT NULL,
	[NameSystem] [nvarchar](20) NULL,
	[Shift] [nvarchar](50) NOT NULL,
	[Pass] [nvarchar](100) NOT NULL,
	[Number_Type_Of_Job] [nvarchar](5) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[Email] [text] NULL,
	[Sex] [nvarchar](50) NULL,
	[Note1] [text] NULL,
	[Note2] [text] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[User_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (1, 1, 1, 5, 2000, 0, N'نق', CAST(N'2020-06-09T15:15:57.587' AS DateTime), N'مقفل', N'معاينة', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (2, 2, 1, 5, 12000, 3000, N'نقداً', CAST(N'2020-06-09T15:16:59.223' AS DateTime), N'1', N'مجارحة الجروح', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (3, 1, 1, 5, 0, 45000, N'نق', CAST(N'2020-06-09T17:31:47.233' AS DateTime), N'1', N'تم سحب المبلغ وترك العملية', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (4, 1, 2, 5, 20000, 25000, N'آجل', CAST(N'2020-07-15T05:59:03.790' AS DateTime), N'مقفل', N'مجارحة الجروح والحوادث', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (5, 1, 3, 5, 1000, 0, N'آجل', CAST(N'2020-07-15T19:44:20.390' AS DateTime), N'مقفل', N'معاينة', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (6, 1, 2, 5, 20000, 25000, N'آجل', CAST(N'2020-07-15T06:14:44.990' AS DateTime), N'مقفل', N'مجارحة الجروح والحوادث', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (7, 1, 4, 5, 1000, 0, N'آجل', CAST(N'2020-07-15T06:17:35.897' AS DateTime), N'مقفل', N'معاينة', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (8, 2, 3, 5, 10000, 9000, N'آجل', CAST(N'2020-08-10T12:13:44.677' AS DateTime), N'مقفل', N'إزالة المياه زرقاء', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (9, 2, 4, 5, 20000, 25000, N'نقداً', CAST(N'2020-08-10T12:14:31.407' AS DateTime), N'مقفل', N'مجارحة الجروح والحوادث', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (10, 2, 5, 5, 2000, 8000, N'نقداً', CAST(N'2020-08-10T12:22:41.027' AS DateTime), N'مقفل', N'إزالة المياه زرقاء', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (11, 1, 6, 5, 2000, 0, N'نقداً', CAST(N'2020-08-11T08:25:13.373' AS DateTime), N'مقفل', N'معاينة', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (12, 2, 6, 5, 80000, 0, N'نق', CAST(N'2020-08-15T11:53:56.430' AS DateTime), N'مفتوح', N'ازالة المياه البيضاء', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (13, 2, 6, 5, 20000, 0, N'نقداً', CAST(N'2020-08-11T08:31:58.720' AS DateTime), N'مقفل', N'تكملة سعر العملية السابقة(إزالة المياه البيضاء)', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (14, 2, 6, 5, 80000, 0, N'نق', CAST(N'2020-08-15T11:53:48.607' AS DateTime), N'مفتوح', N'ازالة المياه البيضاء', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (15, 1, 7, 5, 2000, 0, N'نقداً', CAST(N'2020-08-15T12:06:40.247' AS DateTime), N'مقفل', N'معاينة', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (16, 1, 9, 5, 1000, 0, N'نق', CAST(N'2020-08-16T11:08:21.460' AS DateTime), N'مقفل', N'معاينة', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (17, 2, 10, 5, 20000, 25000, N'نقداً', CAST(N'2020-08-16T11:11:52.483' AS DateTime), N'مقفل', N'مجارحة الجروح والحوادث', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (18, 2, 1, 5, 100000, 50000, N'نقداً', CAST(N'2020-08-17T20:18:03.110' AS DateTime), N'مقفل', N'ازالة المياه البيضاء', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (19, 3, 1, 5, 2000, 0, N'نقداً', CAST(N'2020-08-18T15:08:20.860' AS DateTime), N'مقفل', N'كشافة', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (20, 1, 1, 5, 2000, 0, N'نقداً', CAST(N'2020-08-19T11:44:14.207' AS DateTime), N'مقفل', N'معاينة', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (21, 1, 1, 5, 2000, 0, N'نقداً', CAST(N'2020-08-22T12:12:32.497' AS DateTime), N'مقفل', N'معاينة', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (22, 2, 13, 5, 1500000, 0, N'نقداً', CAST(N'2020-08-23T21:41:25.160' AS DateTime), N'مقفل', N'ازالة المياه البيضاء', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (23, 3, 14, 5, 2000, 0, N'نقداً', CAST(N'2020-08-23T21:42:18.333' AS DateTime), N'مقفل', N'كشافة', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (24, 1, 16, 5, 2000, 0, N'نقداً', CAST(N'2020-08-23T21:49:02.407' AS DateTime), N'مقفل', N'معاينة', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (25, 1, 17, 5, 2000, 0, N'نقداً', CAST(N'2020-08-23T21:51:03.750' AS DateTime), N'مقفل', N'معاينة', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (26, 1, 18, 5, 2000, 0, N'نقداً', CAST(N'2020-08-23T21:51:48.783' AS DateTime), N'مقفل', N'معاينة', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (27, 1, 19, 5, 2000, 0, N'نقداً', CAST(N'2020-08-23T21:53:45.987' AS DateTime), N'مقفل', N'معاينة', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (28, 1, 20, 5, 2000, 0, N'نقداً', CAST(N'2020-08-23T21:54:21.343' AS DateTime), N'مقفل', N'معاينة', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (29, 1, 21, 5, 2000, 0, N'نقداً', CAST(N'2020-08-23T21:56:42.947' AS DateTime), N'مقفل', N'معاينة', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (30, 2, 19, 5, 140000, 10000, N'نقداً', CAST(N'2020-09-14T23:00:07.757' AS DateTime), N'مقفل', N'ازالة المياه البيضاء', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (31, 2, 19, 5, 140000, 20000, N'نقداً', CAST(N'2020-09-14T23:01:00.920' AS DateTime), N'مقفل', N'ازالة المياه البيضاء', N'')
INSERT [dbo].[Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (32, 1, 3, 11, 2000, 0, N'آجل', CAST(N'2020-09-15T06:53:42.917' AS DateTime), N'مقفل', N'معاينة', N'')
INSERT [dbo].[Bond_Book_Type] ([Bond_Name], [Bond_Number], [Bond_Code], [col1], [col2]) VALUES (N'معاينة', 1, N'معاينة', NULL, NULL)
INSERT [dbo].[Bond_Book_Type] ([Bond_Name], [Bond_Number], [Bond_Code], [col1], [col2]) VALUES (N'عملية', 2, N'عملية', NULL, NULL)
INSERT [dbo].[Bond_Book_Type] ([Bond_Name], [Bond_Number], [Bond_Code], [col1], [col2]) VALUES (N'كشافة', 3, N'كشافة', N'', N'')
INSERT [dbo].[Bond_Book_Type] ([Bond_Name], [Bond_Number], [Bond_Code], [col1], [col2]) VALUES (N'علاج', 4, N'علاج1', N'', N'')
INSERT [dbo].[Bond_Book_Type] ([Bond_Name], [Bond_Number], [Bond_Code], [col1], [col2]) VALUES (N'تقرير', 5, N'تقرير', N'', N'')
INSERT [dbo].[Bond_Book_Type] ([Bond_Name], [Bond_Number], [Bond_Code], [col1], [col2]) VALUES (N'إيرادت النظارة', 6, N'  ', N'', N'')
INSERT [dbo].[Clinic] ([Name], [Clinic_id], [Shift], [User_id], [Note1], [Note2]) VALUES (N'عيادة العيون                                      ', 1, N'فترتين              ', 1, NULL, NULL)
INSERT [dbo].[Clinic] ([Name], [Clinic_id], [Shift], [User_id], [Note1], [Note2]) VALUES (N'عيادة العيون                                      ', 2, N'فترتين              ', 5, NULL, NULL)
INSERT [dbo].[Deleted_Bond_Book] ([BondNumber], [BondNumType], [Patient_id], [User_id], [BondAmount], [BondDiscount], [BondCash_or_After], [BondDate], [BondState], [col1], [col2]) VALUES (33, 1, 22, 5, 2000, 0, N'نقداً', CAST(N'2020-09-15T09:47:47.293' AS DateTime), N'مقفل', N'معاينة', N'')
INSERT [dbo].[Lists] ([ListID], [ListName]) VALUES (1, N'المرضى')
INSERT [dbo].[Lists] ([ListID], [ListName]) VALUES (2, N'الفحوصات')
INSERT [dbo].[Lists] ([ListID], [ListName]) VALUES (3, N'العمليات')
INSERT [dbo].[Lists] ([ListID], [ListName]) VALUES (4, N'فحوصات العملية')
INSERT [dbo].[Lists] ([ListID], [ListName]) VALUES (5, N'العودات')
INSERT [dbo].[Lists] ([ListID], [ListName]) VALUES (6, N'ادارة النظام')
INSERT [dbo].[Lists] ([ListID], [ListName]) VALUES (7, N'السندات')
INSERT [dbo].[Lists] ([ListID], [ListName]) VALUES (8, N'البيانات الاساسية')
INSERT [dbo].[Patient] ([Name], [Patient_id], [Date], [Address], [No_File], [Phone], [Age], [User_id], [Clinic_id], [Sex], [Note1], [Note2]) VALUES (N'زكريا ', 1, CAST(N'2020-06-09T15:15:55.050' AS DateTime), N'المجمع', 1, N'77551492', N'25', 5, 1, N'ذكر       ', N'مبرمج', NULL)
INSERT [dbo].[Patient] ([Name], [Patient_id], [Date], [Address], [No_File], [Phone], [Age], [User_id], [Clinic_id], [Sex], [Note1], [Note2]) VALUES (N'وديع عادل الروحاني', 2, CAST(N'2020-07-15T05:15:57.103' AS DateTime), N'الزراعة', 2, N'44444', N'25', 5, 1, N'ذكر       ', N'مبرمج النظام', N'Null')
INSERT [dbo].[Patient] ([Name], [Patient_id], [Date], [Address], [No_File], [Phone], [Age], [User_id], [Clinic_id], [Sex], [Note1], [Note2]) VALUES (N'منال', 3, CAST(N'2020-07-15T06:01:56.543' AS DateTime), N'الزراعة', 3, N'775193114', N'25', 5, 1, N'انثى      ', N'زوجة وديع', NULL)
INSERT [dbo].[Patient] ([Name], [Patient_id], [Date], [Address], [No_File], [Phone], [Age], [User_id], [Clinic_id], [Sex], [Note1], [Note2]) VALUES (N'محمد عادل الشيخ', 4, CAST(N'2020-07-15T06:17:33.807' AS DateTime), N'المستهلك', 4, N'775193114', N'25', 5, 1, N'ذكر       ', N'طالب م4', NULL)
INSERT [dbo].[Patient] ([Name], [Patient_id], [Date], [Address], [No_File], [Phone], [Age], [User_id], [Clinic_id], [Sex], [Note1], [Note2]) VALUES (N'ثامر الحكيمي', 5, CAST(N'2020-08-10T12:22:38.247' AS DateTime), N'الجامعة', 1200, N'71548452', N'5', 5, 1, N'ذكر       ', N'000', N'Null')
INSERT [dbo].[Patient] ([Name], [Patient_id], [Date], [Address], [No_File], [Phone], [Age], [User_id], [Clinic_id], [Sex], [Note1], [Note2]) VALUES (N'محمد احمد السالمي', 6, CAST(N'2020-08-11T08:25:11.020' AS DateTime), N'المجمع', 1201, N'77777', N'25', 5, 1, N'ذكر       ', N'0000', N'Null')
INSERT [dbo].[Patient] ([Name], [Patient_id], [Date], [Address], [No_File], [Phone], [Age], [User_id], [Clinic_id], [Sex], [Note1], [Note2]) VALUES (N'wadee', 7, CAST(N'2020-08-15T12:06:38.497' AS DateTime), N'zraha', 1202, N'775193114', N'25', 5, 1, N'ذكر       ', N' ', NULL)
INSERT [dbo].[Patient] ([Name], [Patient_id], [Date], [Address], [No_File], [Phone], [Age], [User_id], [Clinic_id], [Sex], [Note1], [Note2]) VALUES (N'خديجة', 8, CAST(N'2020-08-15T00:00:00.000' AS DateTime), N'الزراعة', 1203, N'714854741', N'45', 5, 1, N'انثى      ', N'', NULL)
INSERT [dbo].[Patient] ([Name], [Patient_id], [Date], [Address], [No_File], [Phone], [Age], [User_id], [Clinic_id], [Sex], [Note1], [Note2]) VALUES (N'منال', 9, CAST(N'2020-08-16T11:08:20.007' AS DateTime), N'المجمع', 9, N'77551492', N'25', 5, 1, N'ذكر       ', N'مبرمج', NULL)
INSERT [dbo].[Patient] ([Name], [Patient_id], [Date], [Address], [No_File], [Phone], [Age], [User_id], [Clinic_id], [Sex], [Note1], [Note2]) VALUES (N'محمد عادل الشيخ', 10, CAST(N'2020-08-16T11:11:51.017' AS DateTime), N'المجمع', 10, N'77551492', N'25', 5, 1, N'ذكر       ', N'مبرمج', NULL)
INSERT [dbo].[Patient] ([Name], [Patient_id], [Date], [Address], [No_File], [Phone], [Age], [User_id], [Clinic_id], [Sex], [Note1], [Note2]) VALUES (N'وديع عادل الروحاني', 11, CAST(N'2020-07-15T00:00:00.000' AS DateTime), N'الزراعة', 25, N'44444', N'8hlg', 5, 1, N'ذكر       ', N'مبرمج النظام', N'Null')
INSERT [dbo].[Patient] ([Name], [Patient_id], [Date], [Address], [No_File], [Phone], [Age], [User_id], [Clinic_id], [Sex], [Note1], [Note2]) VALUES (N'وديع عادل الروحاني', 12, CAST(N'2020-08-23T21:40:35.253' AS DateTime), N'الزراعة', 26, N'44444', N'25', 5, 1, N'ذكر       ', N'مبرمج النظام', NULL)
INSERT [dbo].[Patient] ([Name], [Patient_id], [Date], [Address], [No_File], [Phone], [Age], [User_id], [Clinic_id], [Sex], [Note1], [Note2]) VALUES (N'gsdfs', 13, CAST(N'2020-08-23T21:41:23.990' AS DateTime), N'saf', 1204, N'lsdjf', N'sdf', 5, 1, N'ذكر       ', N'', NULL)
INSERT [dbo].[Patient] ([Name], [Patient_id], [Date], [Address], [No_File], [Phone], [Age], [User_id], [Clinic_id], [Sex], [Note1], [Note2]) VALUES (N'jkjj', 14, CAST(N'2020-08-23T21:42:17.027' AS DateTime), N'saf', 1205, N'lsdjf', N'sdf', 5, 1, N'ذكر       ', N'', NULL)
INSERT [dbo].[Patient] ([Name], [Patient_id], [Date], [Address], [No_File], [Phone], [Age], [User_id], [Clinic_id], [Sex], [Note1], [Note2]) VALUES (N'sdfd', 15, CAST(N'2020-08-23T21:48:06.800' AS DateTime), N';klj', 1206, N';klj', N';klj', 5, 1, N'ذكر       ', N'l;kj', NULL)
INSERT [dbo].[Patient] ([Name], [Patient_id], [Date], [Address], [No_File], [Phone], [Age], [User_id], [Clinic_id], [Sex], [Note1], [Note2]) VALUES (N'lkfj', 16, CAST(N'2020-08-23T21:49:01.137' AS DateTime), N';lkj', 1207, N';klj', N'jk', 5, 1, N'ذكر       ', N';klj', NULL)
INSERT [dbo].[Patient] ([Name], [Patient_id], [Date], [Address], [No_File], [Phone], [Age], [User_id], [Clinic_id], [Sex], [Note1], [Note2]) VALUES (N'asdlk', 17, CAST(N'2020-08-23T21:51:02.323' AS DateTime), N'sdlkf', 1208, N'sdf', N'sdf', 5, 1, N'ذكر       ', N'sdsf', NULL)
INSERT [dbo].[Patient] ([Name], [Patient_id], [Date], [Address], [No_File], [Phone], [Age], [User_id], [Clinic_id], [Sex], [Note1], [Note2]) VALUES (N'asdlk', 18, CAST(N'2020-08-23T21:51:47.160' AS DateTime), N'sdlkf', 1209, N'sdf', N'sdf', 5, 1, N'ذكر       ', N'sdsf', NULL)
INSERT [dbo].[Patient] ([Name], [Patient_id], [Date], [Address], [No_File], [Phone], [Age], [User_id], [Clinic_id], [Sex], [Note1], [Note2]) VALUES (N'سميبت', 19, CAST(N'2020-08-23T21:53:44.077' AS DateTime), N'سيب', 1210, N'يسينم', N'8اشهر', 5, 1, N'ذكر       ', N'ي', NULL)
INSERT [dbo].[Patient] ([Name], [Patient_id], [Date], [Address], [No_File], [Phone], [Age], [User_id], [Clinic_id], [Sex], [Note1], [Note2]) VALUES (N'سميبت', 20, CAST(N'2020-08-23T21:54:19.897' AS DateTime), N'سيب', 1211, N'يسينم', N'8اشهر', 5, 1, N'ذكر       ', N'ي', N'Null')
INSERT [dbo].[Patient] ([Name], [Patient_id], [Date], [Address], [No_File], [Phone], [Age], [User_id], [Clinic_id], [Sex], [Note1], [Note2]) VALUES (N'سميبت', 21, CAST(N'2020-08-23T21:56:41.703' AS DateTime), N'سيب', 1212, N'45855', N'8اشهر', 5, 1, N'ذكر       ', N'ي', N'Null')
INSERT [dbo].[Patient] ([Name], [Patient_id], [Date], [Address], [No_File], [Phone], [Age], [User_id], [Clinic_id], [Sex], [Note1], [Note2]) VALUES (N'owhd', 22, CAST(N'2020-09-15T07:09:53.533' AS DateTime), N's;df', 1213, N'ssdlk', N'sdf', 5, 1, N'ذكر       ', N'', NULL)
INSERT [dbo].[Patient] ([Name], [Patient_id], [Date], [Address], [No_File], [Phone], [Age], [User_id], [Clinic_id], [Sex], [Note1], [Note2]) VALUES (N'منال محمد', 23, CAST(N'2020-09-15T07:12:53.323' AS DateTime), N'الزراعة', 1214, N'775193114', N'25', 5, 1, N'انثى      ', N'زوجة وديع', NULL)
INSERT [dbo].[Patient] ([Name], [Patient_id], [Date], [Address], [No_File], [Phone], [Age], [User_id], [Clinic_id], [Sex], [Note1], [Note2]) VALUES (N'1', 24, CAST(N'2020-09-15T07:18:46.300' AS DateTime), N'1', 1215, N'1', N'1', 11, 1, N'ذكر       ', N'', NULL)
INSERT [dbo].[Patient] ([Name], [Patient_id], [Date], [Address], [No_File], [Phone], [Age], [User_id], [Clinic_id], [Sex], [Note1], [Note2]) VALUES (N'2', 25, CAST(N'2020-09-15T07:19:38.350' AS DateTime), N'1', 1216, N'1', N'1', 11, 1, N'ذكر       ', N'', NULL)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (5, 1, 1, 1, 1, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (5, 2, 1, 1, 1, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (5, 3, 1, 1, 1, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (5, 4, 1, 1, 1, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (5, 5, 1, 1, 1, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (5, 6, 1, 1, 1, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (5, 7, 1, 1, 1, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (5, 8, 1, 1, 1, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (5, 9, 1, 1, 1, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (5, 10, 1, 1, 1, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (5, 11, 1, 1, 1, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (5, 12, 1, 1, 1, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (9, 1, 0, 0, 0, 0)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (9, 2, 1, 1, 1, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (9, 3, 1, NULL, 1, NULL)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (9, 4, 1, 1, 1, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (9, 5, 1, 1, 1, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (9, 6, 0, 0, 0, 0)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (9, 7, NULL, NULL, NULL, NULL)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (9, 8, 1, 1, 1, 0)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (9, 9, 1, 1, 1, 0)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (9, 10, 1, 1, 1, 0)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (9, 11, 1, 1, 1, 0)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (9, 12, 1, 1, 1, 0)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (5, 13, 1, 1, 1, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (5, 14, 1, 1, 1, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (9, 13, 1, 1, 1, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (9, 14, 1, 1, 1, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (1, 1, 0, 0, 1, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (1, 2, 0, 0, 1, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (1, 3, 0, 0, 0, 0)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (1, 4, 1, 1, 1, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (1, 1, 0, 0, 1, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (1, 5, 1, 1, 1, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (1, 6, 1, 0, 0, 0)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (1, 7, 0, 1, 0, 0)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (1, 8, NULL, NULL, NULL, NULL)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (1, 9, NULL, NULL, NULL, NULL)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (1, 10, NULL, NULL, NULL, NULL)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (1, 11, NULL, NULL, NULL, NULL)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (1, 12, 1, 0, 0, 0)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (1, 13, 1, 0, 0, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (1, 14, NULL, NULL, NULL, NULL)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (10, 1, 1, 0, 0, 0)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (10, 2, 1, 0, 0, 0)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (10, 3, 1, 0, 0, 0)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (10, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (10, 5, NULL, NULL, NULL, NULL)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (10, 6, NULL, NULL, NULL, NULL)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (10, 7, NULL, NULL, NULL, NULL)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (10, 8, 0, 0, 0, 0)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (10, 9, 0, 0, 0, 0)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (10, 10, 1, 1, 1, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (10, 11, 0, 0, 0, 0)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (10, 12, 0, 0, 0, 0)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (10, 13, 1, 0, 0, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (10, 14, NULL, NULL, NULL, NULL)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (5, 15, 1, 1, 1, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (10, 15, 1, 1, 0, 0)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (5, 16, 1, 1, 1, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (11, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (11, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (11, 3, NULL, NULL, NULL, NULL)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (11, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (11, 5, NULL, NULL, NULL, NULL)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (11, 6, NULL, NULL, NULL, NULL)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (11, 7, NULL, NULL, NULL, NULL)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (11, 8, 0, 0, 0, 0)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (11, 9, 0, 0, 0, 0)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (11, 10, 1, 1, 1, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (11, 11, 0, 0, 0, 0)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (11, 12, 0, 0, 0, 0)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (11, 13, 1, 1, 1, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (11, 14, NULL, NULL, NULL, NULL)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (11, 15, 1, 1, 1, 1)
INSERT [dbo].[Priv] ([UserID], [ScreenID], [View], [Add], [Update], [Print]) VALUES (11, 16, 1, 1, 1, 0)
INSERT [dbo].[Routine_Check] ([RoutineCheckID], [D_or_N], [VA], [With_Glasses], [PH], [IOP], [Shp], [Cyl], [Axis], [ShpAuto], [CylAuto], [AxisAuto], [OD_or_OS], [Patient_id], [NoFile], [User_id], [Note1]) VALUES (1, N'D', N'67', N'5', N'76', N'6', N'5', N'6', N'6', N'6', N'6', N'6', N'OD', 2, 2, 5, N'مبرمج النظام')
INSERT [dbo].[Screens] ([ScreenID], [ScreenName], [ListID]) VALUES (1, N'Routine_Check', 2)
INSERT [dbo].[Screens] ([ScreenID], [ScreenName], [ListID]) VALUES (2, N'BIOMETRY', 2)
INSERT [dbo].[Screens] ([ScreenID], [ScreenName], [ListID]) VALUES (3, N'Checked_Patient', 2)
INSERT [dbo].[Screens] ([ScreenID], [ScreenName], [ListID]) VALUES (4, N'Global', 4)
INSERT [dbo].[Screens] ([ScreenID], [ScreenName], [ListID]) VALUES (5, N'Local', 4)
INSERT [dbo].[Screens] ([ScreenID], [ScreenName], [ListID]) VALUES (6, N'FowlloUp', 5)
INSERT [dbo].[Screens] ([ScreenID], [ScreenName], [ListID]) VALUES (7, N'Post_Op_Fowllo', 5)
INSERT [dbo].[Screens] ([ScreenID], [ScreenName], [ListID]) VALUES (8, N'المستخدمين', 6)
INSERT [dbo].[Screens] ([ScreenID], [ScreenName], [ListID]) VALUES (9, N'العيادات', 6)
INSERT [dbo].[Screens] ([ScreenID], [ScreenName], [ListID]) VALUES (10, N'تغيير كلمة المرور', 6)
INSERT [dbo].[Screens] ([ScreenID], [ScreenName], [ListID]) VALUES (11, N'ادارة الصلاحيات', 6)
INSERT [dbo].[Screens] ([ScreenID], [ScreenName], [ListID]) VALUES (12, N'النسخ الاحتياطي', 6)
INSERT [dbo].[Screens] ([ScreenID], [ScreenName], [ListID]) VALUES (13, N'المرضى', 1)
INSERT [dbo].[Screens] ([ScreenID], [ScreenName], [ListID]) VALUES (14, N'العمليات', 3)
INSERT [dbo].[Screens] ([ScreenID], [ScreenName], [ListID]) VALUES (15, N'البيانات الاساسية', 8)
INSERT [dbo].[Screens] ([ScreenID], [ScreenName], [ListID]) VALUES (16, N'السندات', 7)
INSERT [dbo].[Surgery] ([Surgery_id], [Patient_id], [NoFile], [Name], [Date], [Place], [Type], [L_or_R_Eye], [Admit_For], [Narcosis], [Treatment], [User_id], [Axial_Length], [IoI_Power], [Blood_Pressure], [Blood_Sugar], [Name_Assistant]) VALUES (1, 2, 2, N'w', CAST(N'2019-12-17T00:00:00.000' AS DateTime), N'مركز العين', N'w', N'L', N'w', N'w', N'w', 5, N'', N'', N'', N'', N'w')
INSERT [dbo].[Surgery] ([Surgery_id], [Patient_id], [NoFile], [Name], [Date], [Place], [Type], [L_or_R_Eye], [Admit_For], [Narcosis], [Treatment], [User_id], [Axial_Length], [IoI_Power], [Blood_Pressure], [Blood_Sugar], [Name_Assistant]) VALUES (2, 1, 1, N'e', CAST(N'2019-12-17T00:00:00.000' AS DateTime), N'e', N'e', N'L', N'e', N'e', N'e', 5, N'', N'', N'', N'', N'e')
INSERT [dbo].[Surgery] ([Surgery_id], [Patient_id], [NoFile], [Name], [Date], [Place], [Type], [L_or_R_Eye], [Admit_For], [Narcosis], [Treatment], [User_id], [Axial_Length], [IoI_Power], [Blood_Pressure], [Blood_Sugar], [Name_Assistant]) VALUES (3, 3, 3, N'د.وفاء', CAST(N'2020-07-19T00:00:00.000' AS DateTime), N'مركز العين', N'ماء ابيض', N'L', N'   ', N'General', N'   ', 5, N'', N'', N'', N'', N'   ')
INSERT [dbo].[Surgery] ([Surgery_id], [Patient_id], [NoFile], [Name], [Date], [Place], [Type], [L_or_R_Eye], [Admit_For], [Narcosis], [Treatment], [User_id], [Axial_Length], [IoI_Power], [Blood_Pressure], [Blood_Sugar], [Name_Assistant]) VALUES (4, 5, 1200, N'qw', CAST(N'2019-12-17T00:00:00.000' AS DateTime), N'مركز العين', N'w', N'R', N'qw', N'w', N'we', 5, N'', N'', N'', N'', N'w')
INSERT [dbo].[Surgery] ([Surgery_id], [Patient_id], [NoFile], [Name], [Date], [Place], [Type], [L_or_R_Eye], [Admit_For], [Narcosis], [Treatment], [User_id], [Axial_Length], [IoI_Power], [Blood_Pressure], [Blood_Sugar], [Name_Assistant]) VALUES (5, 1, 1, N'e', CAST(N'2019-12-17T00:00:00.000' AS DateTime), N'e', N'e', N'L', N'e', N'e', N'e', 5, N'', N'', N'', N'', N'e')
INSERT [dbo].[SurgeryPrices] ([SurgeryPrice_id], [SurgeryPrice_code], [SurgeryPrice], [SurgeryPrice_name], [SurgeryPrice_note]) VALUES (1, N'CO1o2', 2000, N'معاينة', N'')
INSERT [dbo].[SurgeryPrices] ([SurgeryPrice_id], [SurgeryPrice_code], [SurgeryPrice], [SurgeryPrice_name], [SurgeryPrice_note]) VALUES (2, N'code', 1500000, N'ازالة المياه البيضاء', NULL)
INSERT [dbo].[SurgeryPrices] ([SurgeryPrice_id], [SurgeryPrice_code], [SurgeryPrice], [SurgeryPrice_name], [SurgeryPrice_note]) VALUES (3, N'fdfsd', 2000, N'كشافة', NULL)
INSERT [dbo].[SurgeryPrices] ([SurgeryPrice_id], [SurgeryPrice_code], [SurgeryPrice], [SurgeryPrice_name], [SurgeryPrice_note]) VALUES (4, N'34f', 1000, N'تقرير', N'')
INSERT [dbo].[SurgeryPrices] ([SurgeryPrice_id], [SurgeryPrice_code], [SurgeryPrice], [SurgeryPrice_name], [SurgeryPrice_note]) VALUES (5, N'Yi3O0', 1000, N'إزالة جسم غريب', NULL)
INSERT [dbo].[SurgeryPrices] ([SurgeryPrice_id], [SurgeryPrice_code], [SurgeryPrice], [SurgeryPrice_name], [SurgeryPrice_note]) VALUES (6, N'O1ed', 100000, N'مياه بيضاء عادية', N'')
INSERT [dbo].[Users] ([Name], [User_id], [NameSystem], [Shift], [Pass], [Number_Type_Of_Job], [Phone], [Email], [Sex], [Note1], [Note2]) VALUES (N'نبيلة الوادعي                                                                                       ', 1, N'نبيلة', N'صباحي', N'123', N'1', N'775776856', N'EyeCenter@gmail.com', N'انثى', N'مديرة المركز', NULL)
INSERT [dbo].[Users] ([Name], [User_id], [NameSystem], [Shift], [Pass], [Number_Type_Of_Job], [Phone], [Email], [Sex], [Note1], [Note2]) VALUES (N'وديع عادل يحيى الروحاني', 5, N'h', N'صباحي+مسائي', N'h', N'1', N'775193114', N'EyeCenter@gmail.com', N'ذكر', N'', NULL)
INSERT [dbo].[Users] ([Name], [User_id], [NameSystem], [Shift], [Pass], [Number_Type_Of_Job], [Phone], [Email], [Sex], [Note1], [Note2]) VALUES (N'محمد عمر', 9, N'محمد', N'صباحي+مسائي', N'123', N'4', N'714558051', N'', N'ذكر', N'مساعد مدير المركز', NULL)
INSERT [dbo].[Users] ([Name], [User_id], [NameSystem], [Shift], [Pass], [Number_Type_Of_Job], [Phone], [Email], [Sex], [Note1], [Note2]) VALUES (N'اسامة عبده سعيد السماوي', 10, N'osama', N'مسائي', N'123', N'2', N'770607035', N'Osama@gmail.com', N'ذكر', N'مساعد مبرمج النظام', NULL)
INSERT [dbo].[Users] ([Name], [User_id], [NameSystem], [Shift], [Pass], [Number_Type_Of_Job], [Phone], [Email], [Sex], [Note1], [Note2]) VALUES (N'زكريا', 11, N'z', N'مسائي', N'z', N'1', N'71', N'', N'ذكر', N'', NULL)
ALTER TABLE [dbo].[Bond_Book] ADD  CONSTRAINT [DF_Bond_Book_BondCash_or_After]  DEFAULT ((1)) FOR [BondCash_or_After]
GO
ALTER TABLE [dbo].[Bond_Book] ADD  CONSTRAINT [DF_Bond_Book_BondDate]  DEFAULT (((2020)/(1))/(1)) FOR [BondDate]
GO
ALTER TABLE [dbo].[Bond_Book] ADD  CONSTRAINT [DF_Bond_Book_BondState]  DEFAULT ((1)) FOR [BondState]
GO
ALTER TABLE [dbo].[Clinic] ADD  CONSTRAINT [DF_Clinic_Clinic_id]  DEFAULT ((1)) FOR [Clinic_id]
GO
ALTER TABLE [dbo].[Follow_up] ADD  CONSTRAINT [DF_Follow_up_Date]  DEFAULT (((2020)-(1))-(1)) FOR [Date]
GO
ALTER TABLE [dbo].[Follow_up] ADD  CONSTRAINT [DF_Follow_up_Note1]  DEFAULT ('Eye') FOR [Note1]
GO
ALTER TABLE [dbo].[Follow_up] ADD  CONSTRAINT [DF_Follow_up_Note2]  DEFAULT ('Eye') FOR [Note2]
GO
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Table_1_Pat_date]  DEFAULT ('2020-01-01 20:15:04') FOR [Date]
GO
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_Address]  DEFAULT ('مأرب') FOR [Address]
GO
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_No_File]  DEFAULT ((-2020)) FOR [No_File]
GO
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_Clinic_id]  DEFAULT ((1)) FOR [Clinic_id]
GO
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_Note1]  DEFAULT ('Eye Center') FOR [Note1]
GO
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_Note2]  DEFAULT ('Eye Center') FOR [Note2]
GO
ALTER TABLE [dbo].[Post_Operative_Follow_up] ADD  CONSTRAINT [DF_Post_Operative_Follow_up_Date]  DEFAULT (((2020)-(1))-(1)) FOR [Date]
GO
ALTER TABLE [dbo].[Surgery] ADD  CONSTRAINT [DF_Surgery_Date]  DEFAULT (((2020)-(1))-(1)) FOR [Date]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_Shift]  DEFAULT (N'صباحي + مسائي') FOR [Shift]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_Pass]  DEFAULT ('123') FOR [Pass]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_Email]  DEFAULT ('EyeCenter@gmail.com') FOR [Email]
GO
ALTER TABLE [dbo].[Biometry]  WITH CHECK ADD  CONSTRAINT [FK_Biometry_Patient] FOREIGN KEY([Patient_id])
REFERENCES [dbo].[Patient] ([Patient_id])
GO
ALTER TABLE [dbo].[Biometry] CHECK CONSTRAINT [FK_Biometry_Patient]
GO
ALTER TABLE [dbo].[Biometry]  WITH CHECK ADD  CONSTRAINT [FK_Biometry_Users] FOREIGN KEY([User_id])
REFERENCES [dbo].[Users] ([User_id])
GO
ALTER TABLE [dbo].[Biometry] CHECK CONSTRAINT [FK_Biometry_Users]
GO
ALTER TABLE [dbo].[Bond_Book]  WITH CHECK ADD  CONSTRAINT [FK_Bond_Book_Bond_Book_Type] FOREIGN KEY([BondNumType])
REFERENCES [dbo].[Bond_Book_Type] ([Bond_Number])
GO
ALTER TABLE [dbo].[Bond_Book] CHECK CONSTRAINT [FK_Bond_Book_Bond_Book_Type]
GO
ALTER TABLE [dbo].[Bond_Book]  WITH CHECK ADD  CONSTRAINT [FK_Bond_Book_Patient] FOREIGN KEY([Patient_id])
REFERENCES [dbo].[Patient] ([Patient_id])
GO
ALTER TABLE [dbo].[Bond_Book] CHECK CONSTRAINT [FK_Bond_Book_Patient]
GO
ALTER TABLE [dbo].[Bond_Book]  WITH CHECK ADD  CONSTRAINT [FK_Bond_Book_Users] FOREIGN KEY([User_id])
REFERENCES [dbo].[Users] ([User_id])
GO
ALTER TABLE [dbo].[Bond_Book] CHECK CONSTRAINT [FK_Bond_Book_Users]
GO
ALTER TABLE [dbo].[Checked_Patient]  WITH CHECK ADD  CONSTRAINT [FK_Checked_Patient_Patient] FOREIGN KEY([Patient_id])
REFERENCES [dbo].[Patient] ([Patient_id])
GO
ALTER TABLE [dbo].[Checked_Patient] CHECK CONSTRAINT [FK_Checked_Patient_Patient]
GO
ALTER TABLE [dbo].[Checked_Patient]  WITH CHECK ADD  CONSTRAINT [FK_Checked_Patient_Users] FOREIGN KEY([User_id])
REFERENCES [dbo].[Users] ([User_id])
GO
ALTER TABLE [dbo].[Checked_Patient] CHECK CONSTRAINT [FK_Checked_Patient_Users]
GO
ALTER TABLE [dbo].[Clinic]  WITH CHECK ADD  CONSTRAINT [FK_Clinic_Users] FOREIGN KEY([User_id])
REFERENCES [dbo].[Users] ([User_id])
GO
ALTER TABLE [dbo].[Clinic] CHECK CONSTRAINT [FK_Clinic_Users]
GO
ALTER TABLE [dbo].[Follow_up]  WITH CHECK ADD  CONSTRAINT [FK_Follow_up_Patient] FOREIGN KEY([Patient_id])
REFERENCES [dbo].[Patient] ([Patient_id])
GO
ALTER TABLE [dbo].[Follow_up] CHECK CONSTRAINT [FK_Follow_up_Patient]
GO
ALTER TABLE [dbo].[Follow_up]  WITH CHECK ADD  CONSTRAINT [FK_Follow_up_Users] FOREIGN KEY([User_id])
REFERENCES [dbo].[Users] ([User_id])
GO
ALTER TABLE [dbo].[Follow_up] CHECK CONSTRAINT [FK_Follow_up_Users]
GO
ALTER TABLE [dbo].[Global_Narcosis]  WITH CHECK ADD  CONSTRAINT [FK_Global_Narcosis_Surgery] FOREIGN KEY([Surgery_id])
REFERENCES [dbo].[Surgery] ([Surgery_id])
GO
ALTER TABLE [dbo].[Global_Narcosis] CHECK CONSTRAINT [FK_Global_Narcosis_Surgery]
GO
ALTER TABLE [dbo].[Local_Narcosis]  WITH CHECK ADD  CONSTRAINT [FK_Local_Narcosis_Surgery] FOREIGN KEY([Surgery_id])
REFERENCES [dbo].[Surgery] ([Surgery_id])
GO
ALTER TABLE [dbo].[Local_Narcosis] CHECK CONSTRAINT [FK_Local_Narcosis_Surgery]
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [FK_Patient_Clinic] FOREIGN KEY([Clinic_id])
REFERENCES [dbo].[Clinic] ([Clinic_id])
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Patient_Clinic]
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [FK_Patient_Users] FOREIGN KEY([User_id])
REFERENCES [dbo].[Users] ([User_id])
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Patient_Users]
GO
ALTER TABLE [dbo].[Post_Operative_Follow_up]  WITH CHECK ADD  CONSTRAINT [FK_Post_Operative_Follow_up_Patient] FOREIGN KEY([Patient_id])
REFERENCES [dbo].[Patient] ([Patient_id])
GO
ALTER TABLE [dbo].[Post_Operative_Follow_up] CHECK CONSTRAINT [FK_Post_Operative_Follow_up_Patient]
GO
ALTER TABLE [dbo].[Post_Operative_Follow_up]  WITH CHECK ADD  CONSTRAINT [FK_Post_Operative_Follow_up_Surgery] FOREIGN KEY([Surgery_id])
REFERENCES [dbo].[Surgery] ([Surgery_id])
GO
ALTER TABLE [dbo].[Post_Operative_Follow_up] CHECK CONSTRAINT [FK_Post_Operative_Follow_up_Surgery]
GO
ALTER TABLE [dbo].[Post_Operative_Follow_up]  WITH CHECK ADD  CONSTRAINT [FK_Post_Operative_Follow_up_Users] FOREIGN KEY([User_id])
REFERENCES [dbo].[Users] ([User_id])
GO
ALTER TABLE [dbo].[Post_Operative_Follow_up] CHECK CONSTRAINT [FK_Post_Operative_Follow_up_Users]
GO
ALTER TABLE [dbo].[Priv]  WITH CHECK ADD  CONSTRAINT [FK_Priv_Scteens] FOREIGN KEY([ScreenID])
REFERENCES [dbo].[Screens] ([ScreenID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Priv] CHECK CONSTRAINT [FK_Priv_Scteens]
GO
ALTER TABLE [dbo].[Priv]  WITH CHECK ADD  CONSTRAINT [FK_Priv_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([User_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Priv] CHECK CONSTRAINT [FK_Priv_Users]
GO
ALTER TABLE [dbo].[Routine_Check]  WITH CHECK ADD  CONSTRAINT [FK_Routine_Check_Patient] FOREIGN KEY([Patient_id])
REFERENCES [dbo].[Patient] ([Patient_id])
GO
ALTER TABLE [dbo].[Routine_Check] CHECK CONSTRAINT [FK_Routine_Check_Patient]
GO
ALTER TABLE [dbo].[Routine_Check]  WITH CHECK ADD  CONSTRAINT [FK_Routine_Check_Users] FOREIGN KEY([User_id])
REFERENCES [dbo].[Users] ([User_id])
GO
ALTER TABLE [dbo].[Routine_Check] CHECK CONSTRAINT [FK_Routine_Check_Users]
GO
ALTER TABLE [dbo].[Screens]  WITH CHECK ADD  CONSTRAINT [FK_Scteens_Lists] FOREIGN KEY([ListID])
REFERENCES [dbo].[Lists] ([ListID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Screens] CHECK CONSTRAINT [FK_Scteens_Lists]
GO
ALTER TABLE [dbo].[Surgery]  WITH CHECK ADD  CONSTRAINT [FK_Surgery_Patient] FOREIGN KEY([Patient_id])
REFERENCES [dbo].[Patient] ([Patient_id])
GO
ALTER TABLE [dbo].[Surgery] CHECK CONSTRAINT [FK_Surgery_Patient]
GO
ALTER TABLE [dbo].[Surgery]  WITH CHECK ADD  CONSTRAINT [FK_Surgery_Users] FOREIGN KEY([User_id])
REFERENCES [dbo].[Users] ([User_id])
GO
ALTER TABLE [dbo].[Surgery] CHECK CONSTRAINT [FK_Surgery_Users]
GO
ALTER TABLE [dbo].[System_Record]  WITH CHECK ADD  CONSTRAINT [FK_System_Record_Users] FOREIGN KEY([User_id])
REFERENCES [dbo].[Users] ([User_id])
GO
ALTER TABLE [dbo].[System_Record] CHECK CONSTRAINT [FK_System_Record_Users]
GO
/****** Object:  StoredProcedure [dbo].[BackUpEye]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[BackUpEye]
(
@dbName nvarchar(300),
@msar nvarchar(300),
@fileDate nvarchar(20)
)
as
declare @fileName nvarchar(300);
--set @fileDate = convert(nvarchar(20),getdate(),112);
set @fileName = @msar + @dbName + '-' + @fileDate + '.bak';
BACKUP Database @dbName to Disk = @fileName;
GO
/****** Object:  StoredProcedure [dbo].[BondDateRP]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Script for SelectTopNRows command from SSMS  ******/
CREATE proc [dbo].[BondDateRP]
(@fromDate date,@toDate date)
as


  SELECT dbo.Bond_Book.BondNumber, dbo.Bond_Book.BondNumType, dbo.Bond_Book.Patient_id, dbo.Bond_Book.User_id, dbo.Bond_Book.BondAmount, dbo.Bond_Book.BondDiscount, dbo.Bond_Book.BondCash_or_After, 
                  dbo.Bond_Book.BondDate, dbo.Bond_Book.BondState, dbo.Bond_Book.col1, dbo.Bond_Book.col2, dbo.Bond_Book_Type.Bond_Name, dbo.Patient.Name,@fromDate [FromD],
		@toDate [ToD]
FROM     dbo.Bond_Book INNER JOIN
                  dbo.Bond_Book_Type ON dbo.Bond_Book.BondNumType = dbo.Bond_Book_Type.Bond_Number INNER JOIN
                  dbo.Patient ON dbo.Bond_Book.Patient_id = dbo.Patient.Patient_id AND dbo.Bond_Book.Patient_id = dbo.Patient.Patient_id AND cast(BondDate as date) >= @fromDate and cast(BondDate as date) <= @toDate
				  AND Bond_Book.BondCash_or_After != 'آجل'    








--SELECT patient.[Name],
--		@fromDate [FromD],
--		@toDate [ToD],
--	   [BondNumber],
--	   Bond_Name
--      ,[BondNumType]
--      ,Bond_Book.[Patient_id]
--      ,Bond_Book.[User_id]
--      ,BondAmount
--      ,[BondDiscount]
--      ,[BondCash_or_After]
--      ,[BondDate]
--      ,[BondState]
--      ,Bond_Book.[col1]
--      ,Bond_Book.[col2]
	  
--	  from Bond_Book,patient,Bond_Book_Type
--  where Patient.Patient_id = Bond_Book.Patient_id and cast(BondDate as date) >= @fromDate and cast(BondDate as date) <= @toDate
GO
/****** Object:  StoredProcedure [dbo].[BondDateRP_After]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Script for SelectTopNRows command from SSMS  ******/
create proc [dbo].[BondDateRP_After]
(@fromDate date,@toDate date)
as


  SELECT dbo.Bond_Book.BondNumber, dbo.Bond_Book.BondNumType, dbo.Bond_Book.Patient_id, dbo.Bond_Book.User_id, dbo.Bond_Book.BondAmount, dbo.Bond_Book.BondDiscount, dbo.Bond_Book.BondCash_or_After, 
                  dbo.Bond_Book.BondDate, dbo.Bond_Book.BondState, dbo.Bond_Book.col1, dbo.Bond_Book.col2, dbo.Bond_Book_Type.Bond_Name, dbo.Patient.Name,@fromDate [FromD],
		@toDate [ToD]
FROM     dbo.Bond_Book INNER JOIN
                  dbo.Bond_Book_Type ON dbo.Bond_Book.BondNumType = dbo.Bond_Book_Type.Bond_Number INNER JOIN
                  dbo.Patient ON dbo.Bond_Book.Patient_id = dbo.Patient.Patient_id AND dbo.Bond_Book.Patient_id = dbo.Patient.Patient_id AND cast(BondDate as date) >= @fromDate and cast(BondDate as date) <= @toDate
				  AND Bond_Book.BondCash_or_After = 'آجل'    








--SELECT patient.[Name],
--		@fromDate [FromD],
--		@toDate [ToD],
--	   [BondNumber],
--	   Bond_Name
--      ,[BondNumType]
--      ,Bond_Book.[Patient_id]
--      ,Bond_Book.[User_id]
--      ,BondAmount
--      ,[BondDiscount]
--      ,[BondCash_or_After]
--      ,[BondDate]
--      ,[BondState]
--      ,Bond_Book.[col1]
--      ,Bond_Book.[col2]
	  
--	  from Bond_Book,patient,Bond_Book_Type
--  where Patient.Patient_id = Bond_Book.Patient_id and cast(BondDate as date) >= @fromDate and cast(BondDate as date) <= @toDate
GO
/****** Object:  StoredProcedure [dbo].[Checking_Repeat_ClincID]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  proc [dbo].[Checking_Repeat_ClincID]
@ClincID int
as
select Clinic_id from Clinic
where Clinic_id = @ClincID 
GO
/****** Object:  StoredProcedure [dbo].[Checking_Repeat_NoFile]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Checking_Repeat_NoFile]
@nofile int
as
select No_File from Patient
where No_File = @nofile
GO
/****** Object:  StoredProcedure [dbo].[ChengPassUsers]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ChengPassUsers]

			 (
				   @username nvarchar(100),
				   @OldPass nvarchar(100),
				   @NewPass nvarchar(100)
				   )
as
UPDATE Users
   SET 
      [Pass]				= @NewPass
 WHERE [Pass]				= @OldPass and [NameSystem] = @username
GO
/****** Object:  StoredProcedure [dbo].[Delete_Bond]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Delete_Bond]
@id int
as

DELETE FROM [dbo].[Bond_Book]
      WHERE BondNumber = @id
GO
/****** Object:  StoredProcedure [dbo].[delete_SurgeryPrices]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc  [dbo].[delete_SurgeryPrices]
 @SurgeryPrice_id int  
as
 DELETE FROM SurgeryPrices   
where  SurgeryPrice_id =@SurgeryPrice_id 

GO
/****** Object:  StoredProcedure [dbo].[Get_max_id_Surgery]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Get_max_id_Surgery]

as
select ISNULL(max(Surgery_id),0) from Surgery


--exec InsertSurgery "ss","2019/12/16 07:22:05",1,"mariv","paco",'L',"headick","ss","dd","ss","ss",1,5,100,"ss"
GO
/****** Object:  StoredProcedure [dbo].[Git_Max_Bond_Book_id]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Git_Max_Bond_Book_id]

as
select ISNULL(MAX(BondNumber),0) from Bond_Book
GO
/****** Object:  StoredProcedure [dbo].[Git_Max_id]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[Git_Max_id]

as
select ISNULL(MAX(Patient_id),0) from Patient
GO
/****** Object:  StoredProcedure [dbo].[Git_Max_id_Clinc]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Git_Max_id_Clinc]
as
select ISNULL(MAX(Clinic_id),0) from Clinic
GO
/****** Object:  StoredProcedure [dbo].[Git_Max_id_For_Biometry]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Git_Max_id_For_Biometry]
as
select ISNULL(max(BiometryID),0) from Biometry
GO
/****** Object:  StoredProcedure [dbo].[Git_Max_id_For_Checked_Patient]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Git_Max_id_For_Checked_Patient]
as
select ISNULL(MAX(Checked_PatientID),0) from Checked_Patient
GO
/****** Object:  StoredProcedure [dbo].[Git_Max_id_For_Follow_up]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Git_Max_id_For_Follow_up]
as
select ISNULL(max(FollowUpID),0) from Follow_up
GO
/****** Object:  StoredProcedure [dbo].[Git_Max_id_For_Post_Operative_Follow_up]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Git_Max_id_For_Post_Operative_Follow_up]
as
select ISNULL(max(Post_Oper_FollowID),0) from Post_Operative_Follow_up
GO
/****** Object:  StoredProcedure [dbo].[Git_Max_id_For_RoutineCheck]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Git_Max_id_For_RoutineCheck]

as
select ISNULL(MAX(RoutineCheckID),0) from Routine_Check



GO
/****** Object:  StoredProcedure [dbo].[Git_Max_id_For_Users]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Git_Max_id_For_Users]
as
select ISNULL(max(User_id),0) from Users
GO
/****** Object:  StoredProcedure [dbo].[Git_Max_no]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Git_Max_no]

as
select ISNULL( MAX(No_File),0) from Patient
GO
/****** Object:  StoredProcedure [dbo].[git_max_SurgeryPrices]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc  [dbo].[git_max_SurgeryPrices]
 
as
 select ISNULL(MAX(SurgeryPrice_id),0)+1 from SurgeryPrices
GO
/****** Object:  StoredProcedure [dbo].[insert_SurgeryPrices]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[insert_SurgeryPrices]
 @SurgeryPrice_id int ,
 @SurgeryPrice_code varchar(50) ,
 @SurgeryPrice int ,
 @SurgeryPrice_name varchar(50) ,
 @SurgeryPrice_note varchar(50) 
 as   INSERT INTO  SurgeryPrices(SurgeryPrice_id  ,
 SurgeryPrice_code  ,
SurgeryPrice  ,
 SurgeryPrice_name  ,
 SurgeryPrice_note ) VALUES ( @SurgeryPrice_id  ,
 @SurgeryPrice_code  ,
 @SurgeryPrice  ,
 @SurgeryPrice_name  ,
 @SurgeryPrice_note )  

GO
/****** Object:  StoredProcedure [dbo].[InsertBiometry]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[InsertBiometry]
			 (
			   @BiometryID int,
			   @NoFile int,
			   @OD_or_OS text,
			   @K1 text,
			   @K2 text,
			   @Axial_length text,
			   @A_Constant text,
			   @AC_and_IOL text,
			   @PC_and_IOL text,
			   @B_Scan text,
			   @Patient_id int,
			   @User_id int,
			   @Note1 text
		   )
as
INSERT INTO [dbo].[Biometry]
           (
				[BiometryID]
			   ,[OD_or_OS]
			   ,[K1]
			   ,[K2]
			   ,[Axial_length]
			   ,[A_Constant]
			   ,[AC_and_IOL]
			   ,[PC_and_IOL]
			   ,[B_Scan]
			   ,[Patient_id]
			   ,[User_id]
			   ,[NoFile]
			   ,[Note1]
			   ,[Note2]
		   )
     VALUES
           (
				@BiometryID,
				@OD_or_OS, 
				@K1, 
				@K2, 
				@Axial_length, 
				@A_Constant,
				@AC_and_IOL,
				@PC_and_IOL,
				@B_Scan, 
				@Patient_id, 
				@User_id, 
				@NoFile,
				@Note1, 
				null
		   )
GO
/****** Object:  StoredProcedure [dbo].[InsertBondBook]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InsertBondBook]

(
           @BondNumber int,
           @BondNumType int,
		   @Patient_id int,
		   @User_id int,
           @BondAmount float,
           @BondDiscount float,
           @BondCash_or_After nvarchar(10),
           @BondState nvarchar(50),
		   @col1 nvarchar(50),
		   @col2 nvarchar(50)
		   )

as
INSERT INTO [dbo].[Bond_Book]
		   ([BondNumber]
           ,[BondNumType]
		   ,[Patient_id]
		   ,[User_id]
           ,[BondAmount]
           ,[BondDiscount]
           ,[BondCash_or_After]
           ,[BondDate]
           ,[BondState]
		   ,[col1]
		   ,[col2])
     VALUES
           ( 
		   @BondNumber ,
           @BondNumType ,
		   @Patient_id ,
		   @User_id ,
           @BondAmount ,
           @BondDiscount ,
           @BondCash_or_After ,
           CURRENT_TIMESTAMP ,
           @BondState ,
		   @col1,
		   @col2)
GO
/****** Object:  StoredProcedure [dbo].[InsertBondBookType]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertBondBookType](
	  @Bond_Name nvarchar(100),
      @Bond_Number int,
      @Bond_Code nvarchar(100),
      @col1 nvarchar(50),
      @col2 nvarchar(50)
	  )
	  as
INSERT INTO [dbo].[Bond_Book_Type]
           ([Bond_Name]
           ,[Bond_Number]
           ,[Bond_Code]
           ,[col1]
           ,[col2])
     VALUES
           ( @Bond_Name,
			 @Bond_Number ,
			 @Bond_Code ,
			 @col1,
			 @col2 )
GO
/****** Object:  StoredProcedure [dbo].[InsertChecked_Patient]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[InsertChecked_Patient]	
           (
				@Checked_PatientID int,
				@Present_Complaint text,
				@Previous_Ocular_History text,
				@Using_any_Medicine text,
				@Any_Sensitivity text,
				@Ocular_motility text,
				@Slit_lamp_Examination text,
				@Eyelids text,
				@Cornea text,
				@AC text,
				@Lens text,
				@Vitreous text,
				@Fundus text,
				@Gonioscopy text,
				@UltraSound text,
				@Treatment text,
				@L_or_R_Eye char(1),
				@User_id int,
				@Patient_id int,
				@NoFile int,
				@Note1 text			
		   )

as

INSERT INTO [dbo].[Checked_Patient]
           (
				[Checked_PatientID]
			   ,[Present_Complaint]
			   ,[Previous_Ocular_History]
			   ,[Using_any_Medicine]
			   ,[Any_Sensitivity]
			   ,[Ocular_motility]
			   ,[Slit_lamp_Examination]
			   ,[Eyelids]
			   ,[Cornea]
			   ,[AC]
			   ,[Lens]
			   ,[Vitreous]
			   ,[Fundus]
			   ,[Gonioscopy]
			   ,[UltraSound]
			   ,[Treatment]
			   ,[L_or_R_Eye]
			   ,[User_id]
			   ,[Patient_id]
			   ,[NoFile]
			   ,[Note1]
			   ,[Note2]
		   )
     VALUES
           (
				@Checked_PatientID,
				@Present_Complaint, 
				@Previous_Ocular_History, 
				@Using_any_Medicine,
				@Any_Sensitivity, 
				@Ocular_motility, 
				@Slit_lamp_Examination, 
				@Eyelids, 
				@Cornea, 
				@AC, 
				@Lens, 
				@Vitreous, 
				@Fundus,
				@Gonioscopy, 
				@UltraSound, 
				@Treatment, 
				@L_or_R_Eye, 
				@User_id,
				@Patient_id,
				@NoFile,
				@Note1,
				null
		   )
GO
/****** Object:  StoredProcedure [dbo].[InsertClinic]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[InsertClinic]

			(
			   @Name nchar(50),
			   @Clinic_id int,
			   @Shift nchar(20),
			   @User_id int,
			   @Note1 text
		   )

as
INSERT INTO [dbo].[Clinic]
           ([Name]
           ,[Clinic_id]
           ,[Shift]
           ,[User_id]
           ,[Note1]
           ,[Note2])
     VALUES
           (
			   @Name ,
			   @Clinic_id ,
			   @Shift ,
			   @User_id ,
			   @Note1 ,
			   null
		   )
GO
/****** Object:  StoredProcedure [dbo].[InsertDeleted_Bond_Book]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertDeleted_Bond_Book]

(
           @BondNumber int,
           @BondNumType int,
		   @Patient_id int,
		   @User_id int,
           @BondAmount float,
           @BondDiscount float,
           @BondCash_or_After nvarchar(10),
           @BondState nvarchar(50),
		   @col1 nvarchar(50),
		   @col2 nvarchar(50)
		   )

as
INSERT INTO [dbo].[Deleted_Bond_Book]
		   ([BondNumber]
           ,[BondNumType]
		   ,[Patient_id]
		   ,[User_id]
           ,[BondAmount]
           ,[BondDiscount]
           ,[BondCash_or_After]
           ,[BondDate]
           ,[BondState]
		   ,[col1]
		   ,[col2])
     VALUES
           ( 
		   @BondNumber ,
           @BondNumType ,
		   @Patient_id ,
		   @User_id ,
           @BondAmount ,
           @BondDiscount ,
           @BondCash_or_After ,
           CURRENT_TIMESTAMP ,
           @BondState ,
		   @col1,
		   @col2)
GO
/****** Object:  StoredProcedure [dbo].[InsertFollow_up]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[InsertFollow_up]

		   (
			   @FollowUpID int,
			   @NoFile int,
			   @Result text,
			   @Date nvarchar(30),
			   @Treatment text,
			   @Patient_id int,
			   @User_id int,
			   @Note1 text
			   
		   )
		   as
Insert  Into Follow_up
           ([FollowUpID]
           ,[NoFile]
           ,[Patient_id]
           ,[Date]
           ,[Result]
           ,[Treatment]
           ,[User_id]
           ,[Note1]
           ,[Note2])
     VALUES
           (
			   @FollowUpID,
			   @NoFile,
			   @Patient_id ,
			   CAST(@Date as datetime),
			   @Result ,
			   @Treatment ,
			   @User_id ,
			   @Note1,
			   null
		   )



/*		   
Create Proc InsertStudent
@std_id int , @std_name nvarchar(50),@std_level nvarchar(10),@std_department nvarchar(20)
as
Insert Into Student(Std_Id,Std_Name,Std_Level,Std_Department) 
values (@std_id  , @std_name ,@std_level ,@std_department )

*/
GO
/****** Object:  StoredProcedure [dbo].[InsertGlobal_Narcosis]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[InsertGlobal_Narcosis]

			 (
			   @NoFile int ,
			   @Urea_and_creation text,
			   @BT_and_CT text,
			   @Liver_functor_test text,
			   @ECG text,
			   @C_X_ray text,
			   @Medical text,
			   @ENT_Dr text,
			   @pediatric text,
			   @Surgery_id int,
			   @CBC text,
			   @BS text,
			   @Note1 text
		   )

as
INSERT INTO [dbo].[Global_Narcosis]
           ([NoFile]
		   ,[Urea_and_creation]
           ,[BT_and_CT]
           ,[Liver_functor_test]
           ,[ECG]
           ,[C_X_ray]
           ,[Medical]
           ,[ENT_Dr]
           ,[pediatric]
           ,[Surgery_id]
		   ,[CBC]
		   ,[BS]
           ,[Note1])
     VALUES
           (
			   @NoFile,
			   @Urea_and_creation ,
			   @BT_and_CT ,
			   @Liver_functor_test ,
			   @ECG ,
			   @C_X_ray ,
			   @Medical ,
			   @ENT_Dr ,
			   @pediatric ,
			   @Surgery_id ,
			   @CBC,
			   @BS,
			   @Note1
		   )
GO
/****** Object:  StoredProcedure [dbo].[InsertLocal_Narcosis]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[InsertLocal_Narcosis]

			(
				@NoFile int ,
				@BP text,
				@CBC text,
				@BS text,
				@Viral_Marks_and_HIV text,
				@Surgery_id int,
				@Note1 text
		   )

as
INSERT INTO [dbo].[Local_Narcosis]
           ([NoFile]
		   ,[BP]
           ,[Viral_Marks_and_HIV]
           ,[Surgery_id]
		   ,[CBC]
		   ,[BS]
		   ,[Note1])
     VALUES
           (
				@NoFile,
				@BP ,
				@Viral_Marks_and_HIV ,
				@Surgery_id ,
				@CBC,
				@BS,
				@Note1 
		   )
GO
/****** Object:  StoredProcedure [dbo].[InsertPatient]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[InsertPatient]

			 (
				   @Name nvarchar(100),
				   @Patient_id int,
				   @Address text,
				   @No_File int,
				   @Phone nvarchar(50),
				   @Age nvarchar(50),
				   @User_id int,
				   @Clinic_id int,
				   @Sex nvarchar(10),
				   @Note1 text
		   )

as
INSERT INTO [dbo].[Patient]
           ([Name]
           ,[Patient_id]
           ,[Date]
           ,[Address]
           ,[No_File]
           ,[Phone]
           ,[Age]
           ,[User_id]
           ,[Clinic_id]
           ,[Sex]
           ,[Note1]
           ,[Note2])
     VALUES
           (
				   @Name ,
				   @Patient_id ,
				   CURRENT_TIMESTAMP ,
				   @Address ,
				   @No_File ,
				   @Phone ,
				   @Age ,
				   @User_id ,
				   @Clinic_id ,
				   @Sex ,
				   @Note1 ,
				   null
		   )
GO
/****** Object:  StoredProcedure [dbo].[InsertPatientAfter]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[InsertPatientAfter]

			 (
				   @Name nvarchar(100),
				   @Patient_id int,
				   @Date nvarchar(50),
				   @Address text,
				   @No_File int,
				   @Phone nvarchar(50),
				   @Age nvarchar(50),
				   @User_id int,
				   @Clinic_id int,
				   @Sex nvarchar(10),
				   @Note1 text
		   )

as
INSERT INTO [dbo].[Patient]
           ([Name]
           ,[Patient_id]
           ,[Date]
           ,[Address]
           ,[No_File]
           ,[Phone]
           ,[Age]
           ,[User_id]
           ,[Clinic_id]
           ,[Sex]
           ,[Note1]
           ,[Note2])
     VALUES
           (
				   @Name ,
				   @Patient_id ,
				   CAST(@Date as datetime), 
				   @Address ,
				   @No_File ,
				   @Phone ,
				   @Age ,
				   @User_id ,
				   @Clinic_id ,
				   @Sex ,
				   @Note1 ,
				   null
		   )
GO
/****** Object:  StoredProcedure [dbo].[InsertPost_Operative_Follow_up]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[InsertPost_Operative_Follow_up]

			 (
				   @Post_Oper_FollowID int,
				   @Surgery_id int,
				   @Patient_id int,
				   @NoFile int,
				   @VA text,
				   @PH text,
				   @Date nvarchar(30),
				   @Astigmatism text,
				   @Corneal_Cause text,
				   @Corneal_Opacity text,
				   @C_Odema text,
				   @Retinal_Disease text,
				   @Glaucoma text,
				   @Others text,
				   @User_id int,
				   @Note1 text
			)

as
INSERT INTO [dbo].[Post_Operative_Follow_up]
           ([Post_Oper_FollowID]
           ,[Surgery_id]
           ,[Patient_id]
           ,[NoFile]
           ,[VA]
           ,[PH]
           ,[Date]
           ,[Astigmatism]
           ,[Corneal_Cause]
           ,[Corneal_Opacity]
           ,[C_Odema]
           ,[Retinal_Disease]
           ,[Glaucoma]
           ,[Others]
           ,[User_id]
           ,[Note1])
     VALUES
           (
				   @Post_Oper_FollowID ,
				   @Surgery_id ,
				   @Patient_id ,
				   @NoFile ,
				   @VA ,
				   @PH ,
				   CAST(@Date as datetime) ,
				   @Astigmatism ,
				   @Corneal_Cause ,
				   @Corneal_Opacity ,
				   @C_Odema ,
				   @Retinal_Disease ,
				   @Glaucoma ,
				   @Others ,
				   @User_id ,
				   @Note1
			)
GO
/****** Object:  StoredProcedure [dbo].[InsertRoutine_Check]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[InsertRoutine_Check]

			  (
			   @RoutineCheckID int,
			   @OD_or_OS text,
			   @VA text,
			   @With_Glasses text,
			   @PH text,
			   @IOP text,
			   @User_id int,
			   @Patient_id int,
			   @Shp text,
			   @Cyl text,
			   @Axis text,
			   @ShpAuto text,
			   @CylAuto text,
			   @AxisAuto text,
			   @D_or_N text,
			   @Note1 text,
			   @NoFile int
		   )

as
INSERT INTO [dbo].[Routine_Check]
           ([RoutineCheckID]
		   ,[OD_or_OS]
           ,[VA]
           ,[With_Glasses]
           ,[PH]
           ,[IOP]
           ,[User_id]
           ,[Patient_id]
           ,[Shp]
           ,[Cyl]
           ,[Axis]
		   ,[ShpAuto]
           ,[CylAuto]
           ,[AxisAuto]
           ,[D_or_N]
           ,[Note1]
		   ,[NoFile])
     VALUES
           (
			   @RoutineCheckID,
			   @OD_or_OS ,
			   @VA ,
			   @With_Glasses ,
			   @PH ,
			   @IOP ,
			   @User_id ,
			   @Patient_id ,
			   @Shp ,
			   @Cyl ,
			   @Axis ,
			   @ShpAuto ,
			   @CylAuto ,
			   @AxisAuto ,
			   @D_or_N ,
			   @Note1 ,
			   @NoFile 
		   )
GO
/****** Object:  StoredProcedure [dbo].[InsertSurgery]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[InsertSurgery]

			  (
				   @Name nvarchar(50),
				   @Date nvarchar(30),
				   @Surgery_id int,
				   @Place text,
				   @Type text,
				   @L_or_R_Eye char(1),
				   @Admit_For text,
				   @Narcosis text,
				   @Treatment text,
				   @Patient_id int,
				   @User_id int,
				   @NoFile int,
				   @Axial_Length text,
				   @IoI_Power text,
				   @Blood_Pressure text,
				   @Blood_Sugar text,
				   @Note1 text
		   )

as
INSERT INTO [dbo].[Surgery]
           ([Surgery_id]
           ,[Patient_id]
           ,[NoFile]
           ,[Name]
           ,[Date]
           ,[Place]
           ,[Type]
           ,[L_or_R_Eye]
           ,[Admit_For]
           ,[Narcosis]
           ,[Treatment]
           ,[User_id]
		   ,[Axial_Length]
           ,[IoI_Power]
           ,[Blood_Pressure]
           ,[Blood_Sugar]
           ,[Name_Assistant])
     VALUES
           (
				   
				   @Surgery_id ,
				   @Patient_id ,
				   @NoFile ,
				   @Name ,
				   CAST(@Date as datetime),
				   @Place ,
				   @Type ,
				   @L_or_R_Eye ,
				   @Admit_For ,
				   @Narcosis ,
				   @Treatment ,
				   @User_id ,
				   @Axial_Length ,
				   @IoI_Power ,
				   @Blood_Pressure ,
				   @Blood_Sugar ,
				   @Note1 
		   )
GO
/****** Object:  StoredProcedure [dbo].[InsertSystem_Record]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[InsertSystem_Record]

			   (
				   @Time time(7),
				   @Date datetime,
				   @Operation text,
				   @User_id int,
				   @Note1 text
		   )

as
INSERT INTO [dbo].[System_Record]
           ([Time]
           ,[Date]
           ,[Operation]
           ,[User_id]
           ,[Note1]
           ,[Note2])
     VALUES
           (
				   @Time ,
				   @Date ,
				   @Operation ,
				   @User_id ,
				   @Note1 ,
				   null
		   )
GO
/****** Object:  StoredProcedure [dbo].[InsertUsers]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[InsertUsers]

			 (
				   @Name nvarchar(100),
				   @User_id int,
				   @NameSystem nvarchar(20),
				   @Shift nvarchar(20),
				   @Pass nvarchar(100),
				   @Number_Type_Of_Job nvarchar(5),
				   @Phone nvarchar(50),
				   @Email text,
				   @Sex nvarchar(10),
				   @Note1 text
		   )

as
INSERT INTO [dbo].[Users]
           ([Name]
           ,[User_id]
		   ,[NameSystem]
           ,[Shift]
           ,[Pass]
           ,[Number_Type_Of_Job]
           ,[Phone]
           ,[Email]
           ,[Sex]
           ,[Note1]
           ,[Note2])
     VALUES
          (
				   @Name ,
				   @User_id ,
				   @NameSystem,
				   @Shift ,
				   @Pass ,
				   @Number_Type_Of_Job ,
				   @Phone ,
				   @Email ,
				   @Sex ,
				   @Note1 ,
				   null
		   )
INSERT INTO Priv (ScreenID,UserID) select ScreenID,@User_id from Screens
GO
/****** Object:  StoredProcedure [dbo].[Login]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Login]
@NameSystem nvarchar(100) , @Pass nvarchar(100)
as
select * 
from Users
where NameSystem = @NameSystem and Pass = @Pass
GO
/****** Object:  StoredProcedure [dbo].[NameSurgery]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[NameSurgery]
as
select Patient.Name from Patient,Surgery
where Patient.Patient_id = Surgery.Patient_id
GO
/****** Object:  StoredProcedure [dbo].[NameSurgreyGeneral]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[NameSurgreyGeneral]

as
 select Patient.Name from Patient,Surgery
where Patient.Patient_id = Surgery.Patient_id and Surgery.Narcosis like '%General%'
GO
/****** Object:  StoredProcedure [dbo].[NameSurgreyLocal]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[NameSurgreyLocal]

as
  select Patient.Name from Patient,Surgery
where Patient.Patient_id = Surgery.Patient_id and Surgery.Narcosis like '%Local%'
GO
/****** Object:  StoredProcedure [dbo].[ReportCheckPatient]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ReportCheckPatient]
@NoFile int
as

select   Routine_Check.D_or_N,No_File,RoutineCheckID,D_or_N,VA,With_Glasses,PH,IOP,Shp,Cyl,Axis,ShpAuto,CylAuto,AxisAuto,OD_or_OS,
		 Patient.Name,No_File,Age,Sex,Patient.[Note1],
		 Checked_Patient.Checked_PatientID,L_or_R_Eye,Present_Complaint,Previous_Ocular_History,Using_any_Medicine,Any_Sensitivity,Ocular_motility,Slit_lamp_Examination,Eyelids,Cornea,AC,Lens,Vitreous,Fundus,Gonioscopy,UltraSound,Treatment,Checked_Patient.NoFile

		from Patient,Routine_Check,Checked_Patient
		where Routine_Check.NoFile = Patient.No_File and Patient.No_File = Checked_Patient.NoFile
		
														   
														   
														   
														   
														   
														   
														   
														   
														   
														   
GO
/****** Object:  StoredProcedure [dbo].[search_SurgeryPrices]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc  [dbo].[search_SurgeryPrices]
 @SurgeryPrice_id int  
as
 select * from SurgeryPrices   
where  SurgeryPrice_id =@SurgeryPrice_id
 

GO
/****** Object:  StoredProcedure [dbo].[SearchPatient]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SearchPatient]
@data nvarchar(50)
as
select * from Patient
where Name like '%' + @data + '%' or Address like '%' + @data + '%' or Phone like '%' + @data + '%' or Note1 like '%' + @data + '%' --or [Date] like '%' + CAST(@data as datetime) + '%' 
GO
/****** Object:  StoredProcedure [dbo].[selec_users]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[selec_users]
@data nvarchar(50)
as
select * from Users
where Name like '%' + @data + '%' or NameSystem like '%' + @data + '%' or Phone like '%' + @data + '%'  or [Shift] like '%' + @data + '%'
GO
/****** Object:  StoredProcedure [dbo].[SelecBiometry]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SelecBiometry]
@id int
as
select * from Biometry
where Patient_id = @id or NoFile = @id or BiometryID = @id
GO
/****** Object:  StoredProcedure [dbo].[SelecChecked_Patient]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SelecChecked_Patient]
@id int
as
select * from Checked_Patient
where Patient_id = @id or NoFile = @id or Checked_PatientID = @id
GO
/****** Object:  StoredProcedure [dbo].[SelecClinic]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SelecClinic]
as
select * from Clinic
GO
/****** Object:  StoredProcedure [dbo].[SelecFollow_up]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SelecFollow_up]
@id int
as
select * from Follow_up
where Patient_id = @id or NoFile = @id or FollowUpID = @id
GO
/****** Object:  StoredProcedure [dbo].[SelecGlobal_Narcosis]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SelecGlobal_Narcosis]
@id int
as
select * from Global_Narcosis
where NoFile = @id or Surgery_id = @id
GO
/****** Object:  StoredProcedure [dbo].[SelecLocal_Narcosis]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SelecLocal_Narcosis]
@id int
as
select * from Local_Narcosis
where NoFile = @id or Surgery_id = @id
GO
/****** Object:  StoredProcedure [dbo].[SelecPatient]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SelecPatient]
as
select * from Patient
GO
/****** Object:  StoredProcedure [dbo].[SelecPost_Operative_Follow_up]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SelecPost_Operative_Follow_up]
@id int
as
select * from Post_Operative_Follow_up
where Patient_id = @id or NoFile = @id or Post_Oper_FollowID = @id
GO
/****** Object:  StoredProcedure [dbo].[SelecRoutine_Check]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SelecRoutine_Check]
@id int
as
select * from Routine_Check
where Patient_id = @id or NoFile = @id or RoutineCheckID = @id
GO
/****** Object:  StoredProcedure [dbo].[SelecSurgery]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SelecSurgery]
@id int
as
select * from Surgery
where Surgery_id = @id or NoFile = @id
GO
/****** Object:  StoredProcedure [dbo].[SelecSystem_Record]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SelecSystem_Record]
as
select * from System_Record
GO
/****** Object:  StoredProcedure [dbo].[Select_All_Post_Operative_Follow_up]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Select_All_Post_Operative_Follow_up]
as
select * from Post_Operative_Follow_up
GO
/****** Object:  StoredProcedure [dbo].[select_all_SurgeryPrices]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc  [dbo].[select_all_SurgeryPrices]  
as 
select * from SurgeryPrices 

GO
/****** Object:  StoredProcedure [dbo].[Select_BondTyeb]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Script for SelectTopNRows command from SSMS  ******/
create proc [dbo].[Select_BondTyeb]
@type int
as
SELECT TOP (1000)
	   [Patient].[Name]
	  ,[BondNumber]
      ,[BondNumType]
      ,[Bond_Book].[Patient_id]
      ,[Bond_Book].[User_id]
      ,[BondAmount]
      ,[BondDiscount]
      ,[BondCash_or_After]
      ,[BondDate]
      ,[BondState]
      ,[col1] 
      ,[col2]
  FROM [Eye_Center].[dbo].[Bond_Book],Patient
  where Bond_Book.BondNumType = @type and Bond_Book.Patient_id = Patient.Patient_id--
GO
/****** Object:  StoredProcedure [dbo].[Select_data_Surg_type]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Script for SelectTopNRows command from SSMS  ******/
CREATE proc [dbo].[Select_data_Surg_type]
@data nvarchar(100)
as
SELECT TOP (1000) [BondNumber]
      ,[BondNumType]
      ,[Bond_Book].[Patient_id]
      ,[Bond_Book].[User_id]
      ,[BondAmount]
      ,[BondDiscount]
      ,[BondCash_or_After]
      ,[BondDate]
      ,[BondState]
      ,[col1]
      ,[col2]
	  ,Patient.[Name]
	  ,Patient.[Address]
	  ,Patient.Sex
	  ,Patient.Phone
	  ,Patient.No_File
	  ,Patient.Age
	  
  FROM [Bond_Book],Patient
  where col1 = @data and Patient.Patient_id = Bond_Book.Patient_id
GO
/****** Object:  StoredProcedure [dbo].[Select_Patient_tody]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Select_Patient_tody]
(@fromDate nvarchar(50),@toDate nvarchar(50))  
as
 --set @date = '2020/8/23'
select * from Patient
where CAST([Date] as date)  >= CAST(@fromDate as date) and CAST([Date] as date)  <= CAST(@toDate as date)-- '2020/08/23'-- CAST(@date as datetime)
GO
/****** Object:  StoredProcedure [dbo].[SelectAllBiometry]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SelectAllBiometry]
as
select * from Biometry
GO
/****** Object:  StoredProcedure [dbo].[SelectAllBondBook]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SelectAllBondBook]
as
SELECT [BondNumber]
      ,[BondNumType]
      ,[BondAmount]
      ,[BondDiscount]
      ,[BondCash_or_After]
      ,[BondDate]
      ,[BondState]
      ,[col1]
      ,[col2]
  FROM [dbo].[Bond_Book]
GO
/****** Object:  StoredProcedure [dbo].[SelectAllBondBookType]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SelectAllBondBookType]
as
SELECT [Bond_Name]
      ,[Bond_Number]
      ,[Bond_Code]
      ,[col1]
      ,[col2]
  FROM [dbo].[Bond_Book_Type]
GO
/****** Object:  StoredProcedure [dbo].[SelectAllChecked_Patient]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SelectAllChecked_Patient]
as
select * from Checked_Patient
GO
/****** Object:  StoredProcedure [dbo].[SelectAllFollowUp]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SelectAllFollowUp]
as
select * from Follow_up
GO
/****** Object:  StoredProcedure [dbo].[SelectAllGlobal_Narcosis]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SelectAllGlobal_Narcosis]
as
select * from Global_Narcosis
GO
/****** Object:  StoredProcedure [dbo].[SelectAllPatient]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SelectAllPatient]
as
select * from Patient
order by Patient_id desc
GO
/****** Object:  StoredProcedure [dbo].[SelectAllRoutine_Check]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SelectAllRoutine_Check]
as
select * from Routine_Check
GO
/****** Object:  StoredProcedure [dbo].[SelectAllSurgery]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SelectAllSurgery]
as
select * from Surgery


--exec InsertSurgery "ss","2019/12/16 07:22:05",1,"mariv","paco",'L',"headick","ss","dd","ss","ss",1,5,100,"ss"
GO
/****** Object:  StoredProcedure [dbo].[SelectAllUsers]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SelectAllUsers]
as
select * from Users
GO
/****** Object:  StoredProcedure [dbo].[SelectBond_Patient]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SelectBond_Patient](
@data int,@name nvarchar(100),@noFile nvarchar(50)
)
as
select 
@name[Name],@noFile [File_Number],Bond_Book.BondNumber,Bond_Book.Patient_id,Bond_Book.User_id,BondAmount,BondDiscount,BondCash_or_After,BondDate,BondState,col1
from Bond_Book
where Bond_Book.Patient_id = @data 
order by Bond_Book.BondDate  desc
GO
/****** Object:  StoredProcedure [dbo].[SelectBond_Patient_taj]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[SelectBond_Patient_taj]
as
select 
patient.[Name],Bond_Book.BondNumber,Bond_Book.Patient_id,Bond_Book.[User_id],BondAmount,BondDiscount,BondCash_or_After,BondDate,BondState,col1
from Bond_Book,Patient
where Patient.Patient_id = Bond_Book.Patient_id 

GO
/****** Object:  StoredProcedure [dbo].[SelectBondBook]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SelectBondBook](
@data int
)
as
SELECT [BondNumber]
      ,[BondNumType]
	  ,[Patient_id]
	  ,[User_id]
      ,[BondAmount]
      ,[BondDiscount]
      ,[BondCash_or_After]
      ,cast(BondDate as Date)
      ,[BondState]
      ,[col1]
      ,[col2]
  FROM [dbo].[Bond_Book]

  where BondNumber = @data 
GO
/****** Object:  StoredProcedure [dbo].[SelectBondBookType]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SelectBondBookType](
@BodnNumber int
)
as
SELECT [Bond_Name]
      ,[Bond_Number]
      ,[Bond_Code]
      ,[col1]
      ,[col2]
  FROM [dbo].[Bond_Book_Type]
  where Bond_Number = @BodnNumber
GO
/****** Object:  StoredProcedure [dbo].[selectList]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[selectList]
as
select * from Lists
GO
/****** Object:  StoredProcedure [dbo].[SelectNamepatient]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SelectNamepatient]
@data nvarchar( 100)
as 
select Name from Patient
where Name like '%' + @data + '%'
GO
/****** Object:  StoredProcedure [dbo].[SelectpatientInNum]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SelectpatientInNum]
@id int 
as 
select * from Patient
where Patient_id = @id or No_File = @id 
GO
/****** Object:  StoredProcedure [dbo].[SelectPriv]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SelectPriv]
@idList int,@userid int
		as
		select  Priv.ScreenID,Screens.ScreenName,UserID,[View],[Add],[Update],[Print]  
		from Priv,Screens 
		where Priv.ScreenID = Screens.ScreenID 
				and Screens.ListID = (Select ListID from Lists where ListID = @idList) 
				and Priv.UserID =@userid 
GO
/****** Object:  StoredProcedure [dbo].[SelectPrivScreen]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SelectPrivScreen]
@idscreen int ,@userid int
as
select [View],[Add],[Update],[Print] from Priv
where ScreenID = @idscreen and UserID = @userid
GO
/****** Object:  StoredProcedure [dbo].[SelecUsers]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SelecUsers]
@data nvarchar(50)
as
select * from Users
where Name like '%' + @data + '%' or NameSystem like '%' + @data + '%' or Phone like '%' + @data + '%'  or Shift like '%' + @data + '%'
GO
/****** Object:  StoredProcedure [dbo].[SeletAllcLocal_Narcosis]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SeletAllcLocal_Narcosis]
as
select * from Local_Narcosis
GO
/****** Object:  StoredProcedure [dbo].[SumBondDay]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[SumBondDay]
 --(@data datetime)
 as
  select 
		patient.[Name],
	   [BondNumber]
      ,[BondNumType]
      ,Bond_Book.[Patient_id]
      ,Bond_Book.[User_id]
      ,BondAmount
      ,[BondDiscount]
      ,[BondCash_or_After]
      ,[BondDate]
      ,[BondState]
      ,[col1]
      ,[col2]
	  
	  from Bond_Book,patient --BondDate  like '%' + CAST('2020-06-09' as datetime) + '%'

  where Patient.Patient_id = Bond_Book.Patient_id --and dateadd(dd,0, datediff(dd,0,BondDate)) = @data
  
 -- exec SumBondDay '2020/06/09'
GO
/****** Object:  StoredProcedure [dbo].[update_SurgeryPrices]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc   [dbo].[update_SurgeryPrices]
 @SurgeryPrice_id int ,
 @SurgeryPrice_code varchar(50) ,
 @SurgeryPrice int ,
 @SurgeryPrice_name varchar(50) ,
 @SurgeryPrice_note varchar(50) 
 as   update   SurgeryPrices set SurgeryPrice_id=@SurgeryPrice_id ,
SurgeryPrice_code=@SurgeryPrice_code ,
SurgeryPrice=@SurgeryPrice ,
SurgeryPrice_name=@SurgeryPrice_name ,
SurgeryPrice_note=@SurgeryPrice_note 
where SurgeryPrice_id =@SurgeryPrice_id 

GO
/****** Object:  StoredProcedure [dbo].[UpdateBiometry]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[UpdateBiometry]

			 (
			   @BiometryID int,
			   @NoFile int ,
			   @OD_or_OS text,
			   @K1 text,
			   @K2 text,
			   @Axial_length text,
			   @A_Constant text,
			   @AC_and_IOL text,
			   @PC_and_IOL text,
			   @B_Scan text,
			   @Patient_id int,
			   @User_id int,
			   @Note1 text,
			   @Note2 text
		   )

as
UPDATE [dbo].[Biometry]
   SET [Patient_id]	 = @Patient_id 
	  ,[OD_or_OS]	 = @OD_or_OS
      ,[K1]			 = @K1
      ,[K2]			 = @K2
      ,[Axial_length] = @Axial_length
      ,[A_Constant]	 = @A_Constant
      ,[AC_and_IOL]	 = @AC_and_IOL
      ,[PC_and_IOL]	 = @PC_and_IOL
      ,[B_Scan]		 = @B_Scan
	  ,[User_id]     = @User_id
      ,[Note1]		 = @Note1
      ,[Note2]		 = @Note2
 WHERE [BiometryID]  = @BiometryID and [NoFile]		 = @NoFile
GO
/****** Object:  StoredProcedure [dbo].[UpdateBondBook]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[UpdateBondBook](
		  @BondNumber int,
           @BondNumType int,
		   @Patient_id int,
		   @User_id int,
           @BondAmount float,
           @BondDiscount float,
           @BondCash_or_After nvarchar(2),
           @BondState nvarchar(50),
           @col1 nvarchar(50),
           @col2 nvarchar(50)
)
as

UPDATE [dbo].[Bond_Book]
   SET 
      [BondNumType] =			 @BondNumType ,
      [BondAmount] = 			 @BondAmount ,
	  [Patient_id] =			@Patient_id,
	  [User_id] =			    @User_id,
      [BondDiscount] = 		 @BondDiscount ,
      [BondCash_or_After] = 	 @BondCash_or_After ,
      --[BondDate] = 			 CURRENT_TIMESTAMP,
      [BondState] =			 @BondState ,
      [col1] = 				 @col1 ,
      [col2] = 				 @col2 
 WHERE [BondNumber] = 			 @BondNumber 
GO
/****** Object:  StoredProcedure [dbo].[UpdateBondBookType]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateBondBookType](
			@Bond_Name nvarchar(100),
			@Bond_Number int,
			@Bond_Code nvarchar(100),
			@col1 nvarchar(50),
			@col2 nvarchar(50)
)
as

UPDATE [dbo].[Bond_Book_Type]
   SET [Bond_Name]		 = 	 @Bond_Name,
       [Bond_Code]		 = 	 @Bond_Code,
       [col1]			 = 	 @col1 ,
       [col2]			 = 	 @col2 
 WHERE       [Bond_Number]	 = 	 @Bond_Number 
GO
/****** Object:  StoredProcedure [dbo].[UpdateChecked_Patient]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[UpdateChecked_Patient]

			 (
				@Checked_patientID int,
				@Present_Complaint text,
				@Previous_Ocular_History text,
				@Using_any_Medicine text,
				@Any_Sensitivity text,
				@Ocular_motility text,
				@Slit_lamp_Examination text,
				@Eyelids text,
				@Cornea text,
				@AC text,
				@Lens text,
				@Vitreous text,
				@Fundus text,
				@Gonioscopy text,
				@UltraSound text,
				@Treatment text,
				@L_or_R_Eye char(1),
				@User_id int,
				@Patient_id int,
				@NoFile int,
				@Note1 text	,
				@Note2 text
		   )

as
UPDATE [dbo].[Checked_Patient]

   SET [Present_Complaint]		 = @Present_Complaint
      ,[Previous_Ocular_History] = @Previous_Ocular_History
      ,[Using_any_Medicine]		 = @Using_any_Medicine
      ,[Any_Sensitivity]		 = @Any_Sensitivity
      ,[Ocular_motility]		 = @Ocular_motility
      ,[Slit_lamp_Examination]   = @Slit_lamp_Examination
      ,[Eyelids]				 = @Eyelids
      ,[Cornea]					 = @Cornea
      ,[AC]						 = @AC
      ,[Lens]					 = @Lens
      ,[Vitreous]				 = @Vitreous
      ,[Fundus]					 = @Fundus
      ,[Gonioscopy]				 = @Gonioscopy
      ,[UltraSound]				 = @UltraSound
      ,[Treatment]				 = @Treatment
      ,[L_or_R_Eye]				 = @L_or_R_Eye
	  ,[Patient_id]	    	     = @Patient_id
      ,[User_id]				 = @User_id
      ,[Note1]					 = @Note1
      ,[Note2]					 = @Note2

 WHERE [Checked_patientID]		 = @Checked_patientID and [NoFile]	= @NoFile
GO
/****** Object:  StoredProcedure [dbo].[UpdateClinic]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[UpdateClinic]

			 (
			   @Name nchar(50),
			   @Clinic_id int,
			   @Shift nchar(20),
			   @User_id int,
			   @Note1 text,
			   @Note2 text
		   )

as
UPDATE [dbo].[Clinic]
   SET [Name]		 = @Name      
      ,[Shift]		 = @Shift
	  ,[User_id]	 = @User_id
      ,[Note1]		 = @Note1
      ,[Note2]		 = @Note2

 WHERE [Clinic_id]   = @Clinic_id
GO
/****** Object:  StoredProcedure [dbo].[UpdateFollow_up]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[UpdateFollow_up]

			  (
			   @FollowUpID int,
			   @NoFile int,
			   @Patient_id int,
			   @Date nvarchar(30),
			   @Result text,
			   @Treatment text,
			   @User_id int,
			   @Note1 text,
			   @Note2 text
		   )

as
UPDATE [dbo].[Follow_up]
   SET [Patient_id]  = @Patient_id
	  ,[Date]		 = CAST(@Date as datetime)
	  ,[Result]		 = @Result
      ,[Treatment]	 = @Treatment
      ,[User_id]	 = @User_id
      ,[Note1]		 = @Note1
      ,[Note2]		 = @Note2
					   
 WHERE [FollowUpID]  = @FollowUpID and [NoFile]		 = @NoFile
 
GO
/****** Object:  StoredProcedure [dbo].[UpdateGlobal_Narcosis]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[UpdateGlobal_Narcosis]

			(
			   @Urea_and_creation text,
			   @BT_and_CT text,
			   @Liver_functor_test text,
			   @ECG text,
			   @C_X_ray text,
			   @Medical text,
			   @ENT_Dr text,
			   @pediatric text,
			   @Surgery_id int,
			   @CBC text,
			   @BS text,
			   @Note1 text,
			   @NoFile int
		   )

as
UPDATE [dbo].[Global_Narcosis]
   SET [Urea_and_creation]	= @Urea_and_creation
      ,[BT_and_CT]		    = @BT_and_CT
      ,[Liver_functor_test] = @Liver_functor_test
      ,[ECG]				= @ECG
      ,[C_X_ray]			= @C_X_ray
      ,[Medical]			= @Medical
      ,[ENT_Dr]			    = @ENT_Dr
      ,[pediatric]			= @pediatric
	  ,[CBC]				= @CBC
	  ,[BS]					= @BS
      ,[Note1]				= @Note1
 WHERE [Surgery_id]			= @Surgery_id and [NoFile]	= @NoFile
GO
/****** Object:  StoredProcedure [dbo].[UpdateLocal_Narcosis]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[UpdateLocal_Narcosis]

			(
				@NoFile int,
				@BP text,
				@Viral_Marks_and_HIV text,
				@Surgery_id int,
				@CBC text ,
				@BS text,
				@Note1 text
		   )


as
UPDATE [dbo].[Local_Narcosis]
   SET [BP]						= @BP
      ,[Viral_Marks_and_HIV]    = @Viral_Marks_and_HIV
	  ,[BS]					= @BS
	  ,[CBC]					= @CBC
      ,[Note1]					= @Note1

 WHERE [Surgery_id]			    = @Surgery_id and [NoFile]	= @NoFile
GO
/****** Object:  StoredProcedure [dbo].[UpdatePatient]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[UpdatePatient]

			(
				   @Name nvarchar(100),
				   @Patient_id int,
				   --@Date datetime,
				   @Address text,
				   @No_File int,
				   @Phone nvarchar(10),
				   @Age nvarchar(50),
				   @User_id int,
				   @Clinic_id int,
				   @Sex nvarchar(10),
				   @Note1 text,
				   @Note2 text
		   )


as
UPDATE [dbo].[Patient]
   SET [Name]		 = @Name
     -- ,[Date]		 = @Date
      ,[Address]	 = @Address
      ,[Phone]		 = @Phone
      ,[Age]		 = @Age
      ,[User_id]	 = @User_id
      ,[Clinic_id]	 = @Clinic_id
      ,[Sex]		 = @Sex
      ,[Note1]		 = @Note1
      ,[Note2]		 = @Note2

 WHERE [Patient_id]  = @Patient_id and [No_File]	 = @No_File
GO
/****** Object:  StoredProcedure [dbo].[UpdatePost_Operative_Follow_up]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[UpdatePost_Operative_Follow_up]

			(
				   @Post_Oper_FollowID int,
				   @Surgery_id int,
				   @Patient_id int,
				   @NoFile int,
				   @VA text,
				   @PH text,
				   @Date nvarchar(30),
				   @Astigmatism text,
				   @Corneal_Cause text,
				   @Corneal_Opacity text,
				   @C_Odema text,
				   @Retinal_Disease text,
				   @Glaucoma text,
				   @Others text,
				   @User_id int,
				   @Note1 text
			)
as
UPDATE [dbo].[Post_Operative_Follow_up]
   SET [VA]					= @VA
      ,[PH]					= @PH
      ,[Date]			    = CAST(@Date as datetime)
      ,[Astigmatism]	    = @Astigmatism
      ,[Corneal_Cause]		= @Corneal_Cause
      ,[Corneal_Opacity]    = @Corneal_Opacity
      ,[C_Odema]			= @C_Odema
      ,[Retinal_Disease]	= @Retinal_Disease
      ,[Glaucoma]			= @Glaucoma
      ,[Others]				= @Others
      ,[User_id]			= @User_id
      ,[Note1]				= @Note1

 WHERE [Post_Oper_FollowID] = @Post_Oper_FollowID and [NoFile]				= @NoFile and [Surgery_id]			= @Surgery_id and [Patient_id]			= @Patient_id
 
GO
/****** Object:  StoredProcedure [dbo].[UpdatePriv]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[UpdatePriv]

			 (
			   @UserID int,
		       @ScreenID int,
			   @View bit,
			   @Add bit,
			   @Update bit,
			   @Print bit
) 
as
UPDATE Priv

   SET [View]		   = @View
      ,[Add]		   = @Add
      ,[Update]		   = @Update
      ,[Print]		   = @Print
 WHERE [UserID]		   = @UserID

		and
      [ScreenID]	   = @ScreenID
GO
/****** Object:  StoredProcedure [dbo].[UpdateRoutine_Check]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[UpdateRoutine_Check]

			 (
			   @RoutineCheckID int,
			   @OD_or_OS text,
			   @VA text,
			   @With_Glasses text,
			   @PH text,
			   @IOP text,
			   @User_id int,
			   @Patient_id int,
			   @Shp text,
			   @Cyl text,
			   @Axis text,
			   @ShpAuto text,
			   @CylAuto text,
			   @AxisAuto text,
			   @D_or_N text,
			   @Note1 text,
			   @NoFile int
		   )
as
UPDATE [dbo].[Routine_Check]
   SET [OD_or_OS]		= @OD_or_OS
      ,[VA]				= @VA
      ,[With_Glasses]	= @With_Glasses
      ,[PH]				= @PH
      ,[IOP]			= @IOP
      ,[User_id]		= @User_id
      ,[Patient_id]		= @Patient_id
      ,[Shp]			= @Shp
      ,[Cyl]			= @Cyl
      ,[Axis]			= @Axis
	  ,[ShpAuto]		= @ShpAuto
      ,[CylAuto]		= @CylAuto
      ,[AxisAuto]		= @AxisAuto
      ,[D_or_N]			= @D_or_N
      ,[Note1]			= @Note1

 WHERE  [RoutineCheckID] = @RoutineCheckID and [NoFile]			= @NoFile
GO
/****** Object:  StoredProcedure [dbo].[UpdateSurgery]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[UpdateSurgery]

			 (
				   @Name nchar(50),
				   @Date nvarchar(30),
				   @Surgery_id int,
				   @Place text,
				   @Type text,
				   @L_or_R_Eye char(1),
				   @Admit_For text,
				   @Narcosis text,
				   @Treatment text,
				   @Patient_id int,
				   @User_id int,
				   @NoFile int ,
				   @Axial_Length text,
				   @IoI_Power text,
				   @Blood_Pressure text,
				   @Blood_Sugar text,
				   @Note1 text
		   )
as
UPDATE [dbo].[Surgery]
   SET [Name]				= @Name
      ,[Date]				= CAST(@Date as datetime)
      ,[Place]				= @Place
      ,[Type]				= @Type
      ,[L_or_R_Eye]			= @L_or_R_Eye
      ,[Admit_For]			= @Admit_For
      ,[Narcosis]			= @Narcosis
      ,[Treatment]			= @Treatment
      ,[User_id]			= @User_id
	  ,[Axial_Length]		= @Axial_Length 
      ,[IoI_Power]			= @IoI_Power 
      ,[Blood_Pressure]		= @Blood_Pressure 
      ,[Blood_Sugar]		= @Blood_Sugar 
      ,[Name_Assistant]				= @Note1

 WHERE [Surgery_id]			= @Surgery_id and [NoFile]	= @NoFile and [Patient_id]	= @Patient_id
GO
/****** Object:  StoredProcedure [dbo].[UpdateUsers]    Script Date: 9/23/2020 6:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[UpdateUsers]

			 (
				   @Name nvarchar(100),
				   @User_id int,
				   @NameSystem nvarchar(20),
				   @Shift nvarchar(20),
				   @Number_Type_Of_Job nvarchar(5),
				   @Phone numeric(14,0),
				   @Email text,
				   @Sex nvarchar(10),
				   @Note1 text
		   )
as
UPDATE [dbo].[Users]
   SET [Name]				= @Name
	  ,[NameSystem]			= @NameSystem
      ,[Shift]				= @Shift
      ,[Number_Type_Of_Job] = @Number_Type_Of_Job
      ,[Phone]				= @Phone
      ,[Email]				= @Email
      ,[Sex]  				= @Sex
      ,[Note1]				= @Note1
 WHERE [User_id]			= @User_id
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'نوع المستخدم 
1: مدير النظام 
2:دكتور
3:فني
4:مستخدم عادي مثل الاستقبال
ولكل مستخدم صلاحيات معينة في النظام' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Number_Type_Of_Job'
GO
USE [master]
GO
ALTER DATABASE [Eye_Center] SET  READ_WRITE 
GO
