namespace WeatherMeApp
{
    partial class loginForm
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
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.linkToReg = new System.Windows.Forms.Label();
            this.orAdditionalLabelLogin1 = new System.Windows.Forms.Label();
            this.orLabelLogin = new System.Windows.Forms.Label();
            this.hintTextPasswordLogin = new System.Windows.Forms.GroupBox();
            this.PasswordTableLayoutLogin = new System.Windows.Forms.TableLayoutPanel();
            this.passwordFieldLogin = new System.Windows.Forms.TextBox();
            this.hintTextEmailLogin = new System.Windows.Forms.GroupBox();
            this.EmailTableLayoutLogin = new System.Windows.Forms.TableLayoutPanel();
            this.emailFieldLogin = new System.Windows.Forms.TextBox();
            this.greetingsTextLogin2 = new System.Windows.Forms.Label();
            this.greetingsTextLogin1 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.appName = new System.Windows.Forms.Label();
            this.sunPicture = new System.Windows.Forms.PictureBox();
            this.greetingsTextLabel = new System.Windows.Forms.Label();
            this.groupBoxLogin.SuspendLayout();
            this.PasswordTableLayoutLogin.SuspendLayout();
            this.EmailTableLayoutLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sunPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxLogin.Controls.Add(this.linkToReg);
            this.groupBoxLogin.Controls.Add(this.orAdditionalLabelLogin1);
            this.groupBoxLogin.Controls.Add(this.orLabelLogin);
            this.groupBoxLogin.Controls.Add(this.hintTextPasswordLogin);
            this.groupBoxLogin.Controls.Add(this.PasswordTableLayoutLogin);
            this.groupBoxLogin.Controls.Add(this.hintTextEmailLogin);
            this.groupBoxLogin.Controls.Add(this.EmailTableLayoutLogin);
            this.groupBoxLogin.Controls.Add(this.greetingsTextLogin2);
            this.groupBoxLogin.Controls.Add(this.greetingsTextLogin1);
            this.groupBoxLogin.Controls.Add(this.buttonLogin);
            this.groupBoxLogin.Location = new System.Drawing.Point(729, 148);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(460, 768);
            this.groupBoxLogin.TabIndex = 2;
            this.groupBoxLogin.TabStop = false;
            // 
            // linkToReg
            // 
            this.linkToReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkToReg.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkToReg.Location = new System.Drawing.Point(262, 458);
            this.linkToReg.Name = "linkToReg";
            this.linkToReg.Size = new System.Drawing.Size(138, 56);
            this.linkToReg.TabIndex = 13;
            this.linkToReg.Text = "REGISTER HERE";
            this.linkToReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkToReg.Click += new System.EventHandler(this.linkToReg_Click);
            // 
            // orAdditionalLabelLogin1
            // 
            this.orAdditionalLabelLogin1.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orAdditionalLabelLogin1.Location = new System.Drawing.Point(66, 458);
            this.orAdditionalLabelLogin1.Name = "orAdditionalLabelLogin1";
            this.orAdditionalLabelLogin1.Size = new System.Drawing.Size(211, 56);
            this.orAdditionalLabelLogin1.TabIndex = 12;
            this.orAdditionalLabelLogin1.Text = "Don\'t have an account?";
            this.orAdditionalLabelLogin1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orLabelLogin
            // 
            this.orLabelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.orLabelLogin.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orLabelLogin.Location = new System.Drawing.Point(36, 380);
            this.orLabelLogin.Name = "orLabelLogin";
            this.orLabelLogin.Size = new System.Drawing.Size(389, 56);
            this.orLabelLogin.TabIndex = 11;
            this.orLabelLogin.Text = "Or";
            this.orLabelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hintTextPasswordLogin
            // 
            this.hintTextPasswordLogin.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hintTextPasswordLogin.Location = new System.Drawing.Point(50, 208);
            this.hintTextPasswordLogin.Name = "hintTextPasswordLogin";
            this.hintTextPasswordLogin.Size = new System.Drawing.Size(76, 18);
            this.hintTextPasswordLogin.TabIndex = 8;
            this.hintTextPasswordLogin.TabStop = false;
            this.hintTextPasswordLogin.Text = "Password";
            // 
            // PasswordTableLayoutLogin
            // 
            this.PasswordTableLayoutLogin.BackColor = System.Drawing.SystemColors.Window;
            this.PasswordTableLayoutLogin.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.PasswordTableLayoutLogin.ColumnCount = 1;
            this.PasswordTableLayoutLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PasswordTableLayoutLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PasswordTableLayoutLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PasswordTableLayoutLogin.Controls.Add(this.passwordFieldLogin, 0, 0);
            this.PasswordTableLayoutLogin.Location = new System.Drawing.Point(36, 223);
            this.PasswordTableLayoutLogin.Name = "PasswordTableLayoutLogin";
            this.PasswordTableLayoutLogin.RowCount = 1;
            this.PasswordTableLayoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PasswordTableLayoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PasswordTableLayoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PasswordTableLayoutLogin.Size = new System.Drawing.Size(389, 56);
            this.PasswordTableLayoutLogin.TabIndex = 10;
            // 
            // passwordFieldLogin
            // 
            this.passwordFieldLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordFieldLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordFieldLogin.Font = new System.Drawing.Font("Yu Gothic", 15.75F);
            this.passwordFieldLogin.Location = new System.Drawing.Point(4, 11);
            this.passwordFieldLogin.Name = "passwordFieldLogin";
            this.passwordFieldLogin.Size = new System.Drawing.Size(381, 34);
            this.passwordFieldLogin.TabIndex = 0;
            this.passwordFieldLogin.UseSystemPasswordChar = true;
            // 
            // hintTextEmailLogin
            // 
            this.hintTextEmailLogin.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hintTextEmailLogin.Location = new System.Drawing.Point(50, 126);
            this.hintTextEmailLogin.Name = "hintTextEmailLogin";
            this.hintTextEmailLogin.Size = new System.Drawing.Size(57, 19);
            this.hintTextEmailLogin.TabIndex = 7;
            this.hintTextEmailLogin.TabStop = false;
            this.hintTextEmailLogin.Text = "Email";
            // 
            // EmailTableLayoutLogin
            // 
            this.EmailTableLayoutLogin.BackColor = System.Drawing.SystemColors.Window;
            this.EmailTableLayoutLogin.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.EmailTableLayoutLogin.ColumnCount = 1;
            this.EmailTableLayoutLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EmailTableLayoutLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EmailTableLayoutLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EmailTableLayoutLogin.Controls.Add(this.emailFieldLogin, 0, 0);
            this.EmailTableLayoutLogin.Location = new System.Drawing.Point(36, 143);
            this.EmailTableLayoutLogin.Name = "EmailTableLayoutLogin";
            this.EmailTableLayoutLogin.RowCount = 1;
            this.EmailTableLayoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EmailTableLayoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EmailTableLayoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EmailTableLayoutLogin.Size = new System.Drawing.Size(389, 56);
            this.EmailTableLayoutLogin.TabIndex = 9;
            // 
            // emailFieldLogin
            // 
            this.emailFieldLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.emailFieldLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailFieldLogin.Font = new System.Drawing.Font("Yu Gothic", 15.75F);
            this.emailFieldLogin.Location = new System.Drawing.Point(4, 11);
            this.emailFieldLogin.Name = "emailFieldLogin";
            this.emailFieldLogin.Size = new System.Drawing.Size(381, 34);
            this.emailFieldLogin.TabIndex = 0;
            // 
            // greetingsTextLogin2
            // 
            this.greetingsTextLogin2.Font = new System.Drawing.Font("Yu Gothic Medium", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greetingsTextLogin2.Location = new System.Drawing.Point(28, 65);
            this.greetingsTextLogin2.Name = "greetingsTextLogin2";
            this.greetingsTextLogin2.Size = new System.Drawing.Size(349, 44);
            this.greetingsTextLogin2.TabIndex = 5;
            this.greetingsTextLogin2.Text = "Login to Account";
            // 
            // greetingsTextLogin1
            // 
            this.greetingsTextLogin1.Font = new System.Drawing.Font("Yu Gothic UI", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greetingsTextLogin1.ForeColor = System.Drawing.Color.Black;
            this.greetingsTextLogin1.Location = new System.Drawing.Point(35, 33);
            this.greetingsTextLogin1.Name = "greetingsTextLogin1";
            this.greetingsTextLogin1.Size = new System.Drawing.Size(164, 23);
            this.greetingsTextLogin1.TabIndex = 4;
            this.greetingsTextLogin1.Text = "WELCOME BACK";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.ForeColor = System.Drawing.Color.Transparent;
            this.buttonLogin.Location = new System.Drawing.Point(36, 302);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(389, 56);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // appName
            // 
            this.appName.BackColor = System.Drawing.Color.Transparent;
            this.appName.Font = new System.Drawing.Font("Yu Gothic Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appName.ForeColor = System.Drawing.Color.White;
            this.appName.Location = new System.Drawing.Point(320, 236);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(197, 33);
            this.appName.TabIndex = 7;
            this.appName.Text = "WeatherMe";
            // 
            // sunPicture
            // 
            this.sunPicture.BackColor = System.Drawing.Color.Transparent;
            this.sunPicture.Image = global::WeatherMeApp.Properties.Resources.sun_icon_final__1_;
            this.sunPicture.Location = new System.Drawing.Point(250, 219);
            this.sunPicture.Name = "sunPicture";
            this.sunPicture.Size = new System.Drawing.Size(67, 67);
            this.sunPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sunPicture.TabIndex = 6;
            this.sunPicture.TabStop = false;
            // 
            // greetingsTextLabel
            // 
            this.greetingsTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.greetingsTextLabel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greetingsTextLabel.ForeColor = System.Drawing.Color.Transparent;
            this.greetingsTextLabel.Location = new System.Drawing.Point(250, 432);
            this.greetingsTextLabel.Name = "greetingsTextLabel";
            this.greetingsTextLabel.Size = new System.Drawing.Size(380, 245);
            this.greetingsTextLabel.TabIndex = 5;
            this.greetingsTextLabel.Text = "Explore the world with WeatherMe...\r\n\r\n... your personal weather companion. Recei" +
    "ve personalized recommendations, and stay informed about the conditions that mat" +
    "ter to you. Enjoy your journey!\r\n";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeatherMeApp.Properties.Resources.background_final;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1424, 912);
            this.Controls.Add(this.appName);
            this.Controls.Add(this.sunPicture);
            this.Controls.Add(this.greetingsTextLabel);
            this.Controls.Add(this.groupBoxLogin);
            this.MaximizeBox = false;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeatherMe";
            this.groupBoxLogin.ResumeLayout(false);
            this.PasswordTableLayoutLogin.ResumeLayout(false);
            this.PasswordTableLayoutLogin.PerformLayout();
            this.EmailTableLayoutLogin.ResumeLayout(false);
            this.EmailTableLayoutLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sunPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Label linkToReg;
        private System.Windows.Forms.Label orAdditionalLabelLogin1;
        private System.Windows.Forms.Label orLabelLogin;
        private System.Windows.Forms.GroupBox hintTextPasswordLogin;
        private System.Windows.Forms.TableLayoutPanel PasswordTableLayoutLogin;
        private System.Windows.Forms.TextBox passwordFieldLogin;
        private System.Windows.Forms.TableLayoutPanel EmailTableLayoutLogin;
        private System.Windows.Forms.TextBox emailFieldLogin;
        private System.Windows.Forms.Label greetingsTextLogin2;
        private System.Windows.Forms.Label greetingsTextLogin1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.GroupBox hintTextEmailLogin;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.PictureBox sunPicture;
        private System.Windows.Forms.Label greetingsTextLabel;
    }
}