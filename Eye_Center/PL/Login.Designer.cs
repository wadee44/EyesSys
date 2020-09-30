namespace Eye_Center.PL
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSittingConnection = new DevExpress.XtraEditors.SimpleButton();
            this.btCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btLogin = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txPass = new DevExpress.XtraEditors.TextEdit();
            this.txUserName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txUserName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.ContentImage = global::Eye_Center.Properties.Resources.LoginImage;
            this.panelControl1.Controls.Add(this.btnSittingConnection);
            this.panelControl1.Controls.Add(this.btCancel);
            this.panelControl1.Controls.Add(this.btLogin);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txPass);
            this.panelControl1.Controls.Add(this.txUserName);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(710, 468);
            this.panelControl1.TabIndex = 0;
            // 
            // btnSittingConnection
            // 
            this.btnSittingConnection.Appearance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSittingConnection.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSittingConnection.Appearance.Options.UseFont = true;
            this.btnSittingConnection.Appearance.Options.UseForeColor = true;
            this.btnSittingConnection.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btnSittingConnection.AppearanceHovered.Options.UseForeColor = true;
            this.btnSittingConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSittingConnection.ImageOptions.Image = global::Eye_Center.Properties.Resources.connection;
            this.btnSittingConnection.Location = new System.Drawing.Point(220, 324);
            this.btnSittingConnection.Name = "btnSittingConnection";
            this.btnSittingConnection.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSittingConnection.Size = new System.Drawing.Size(252, 29);
            this.btnSittingConnection.TabIndex = 4;
            this.btnSittingConnection.Text = "إعدادات الاتصال ";
            this.btnSittingConnection.Click += new System.EventHandler(this.btnSittingConnection_Click);
            // 
            // btCancel
            // 
            this.btCancel.Appearance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Appearance.ForeColor = System.Drawing.Color.White;
            this.btCancel.Appearance.Options.UseFont = true;
            this.btCancel.Appearance.Options.UseForeColor = true;
            this.btCancel.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btCancel.AppearanceHovered.Options.UseForeColor = true;
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel.ImageOptions.Image = global::Eye_Center.Properties.Resources.exit;
            this.btCancel.Location = new System.Drawing.Point(220, 278);
            this.btCancel.Name = "btCancel";
            this.btCancel.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btCancel.Size = new System.Drawing.Size(94, 29);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "خروج";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btLogin
            // 
            this.btLogin.Appearance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Appearance.ForeColor = System.Drawing.Color.White;
            this.btLogin.Appearance.Options.UseFont = true;
            this.btLogin.Appearance.Options.UseForeColor = true;
            this.btLogin.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btLogin.AppearanceHovered.Options.UseForeColor = true;
            this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogin.ImageOptions.Image = global::Eye_Center.Properties.Resources.enter__2_;
            this.btLogin.Location = new System.Drawing.Point(381, 278);
            this.btLogin.Name = "btLogin";
            this.btLogin.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btLogin.Size = new System.Drawing.Size(91, 29);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "دخول";
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // label4
            // 
            this.label4.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Appearance.Options.UseFont = true;
            this.label4.Appearance.Options.UseForeColor = true;
            this.label4.Location = new System.Drawing.Point(89, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = ": كلمة المرور";
            this.label4.Visible = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(381, 225);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 23);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = ": كلمة المرور";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(89, 72);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(182, 28);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "مركز العين الاستشاري";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(381, 171);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(97, 23);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = ": اسم المستخدم";
            // 
            // txPass
            // 
            this.txPass.Location = new System.Drawing.Point(206, 222);
            this.txPass.Name = "txPass";
            this.txPass.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.txPass.Properties.Appearance.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPass.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txPass.Properties.Appearance.Options.UseBackColor = true;
            this.txPass.Properties.Appearance.Options.UseFont = true;
            this.txPass.Properties.Appearance.Options.UseForeColor = true;
            this.txPass.Properties.Appearance.Options.UseTextOptions = true;
            this.txPass.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txPass.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txPass.Properties.PasswordChar = '*';
            this.txPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txPass.Size = new System.Drawing.Size(169, 30);
            this.txPass.TabIndex = 1;
            this.txPass.TextChanged += new System.EventHandler(this.txPass_TextChanged);
            // 
            // txUserName
            // 
            this.txUserName.Location = new System.Drawing.Point(206, 168);
            this.txUserName.Name = "txUserName";
            this.txUserName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.txUserName.Properties.Appearance.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txUserName.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txUserName.Properties.Appearance.Options.UseBackColor = true;
            this.txUserName.Properties.Appearance.Options.UseFont = true;
            this.txUserName.Properties.Appearance.Options.UseForeColor = true;
            this.txUserName.Properties.Appearance.Options.UseTextOptions = true;
            this.txUserName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txUserName.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txUserName.Size = new System.Drawing.Size(169, 30);
            this.txUserName.TabIndex = 0;
            this.txUserName.TextChanged += new System.EventHandler(this.txUserName_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 468);
            this.Controls.Add(this.panelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txUserName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txUserName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txPass;
        private DevExpress.XtraEditors.SimpleButton btnSittingConnection;
        private DevExpress.XtraEditors.SimpleButton btCancel;
        private DevExpress.XtraEditors.SimpleButton btLogin;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}