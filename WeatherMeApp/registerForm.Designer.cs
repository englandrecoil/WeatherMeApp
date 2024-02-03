using System.Drawing;
using System.Windows.Forms;

namespace WeatherMeApp
{
    partial class registerForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonReg = new System.Windows.Forms.Button();
            this.groupBoxReg = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.orAdditionalLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.hintTextPassword = new System.Windows.Forms.GroupBox();
            this.PasswordTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.hintTextEmail = new System.Windows.Forms.GroupBox();
            this.EmailTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.nameEmail = new System.Windows.Forms.TextBox();
            this.hintTextName = new System.Windows.Forms.GroupBox();
            this.nameTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.nameField = new System.Windows.Forms.TextBox();
            this.greetingsText2 = new System.Windows.Forms.Label();
            this.greetingsText1 = new System.Windows.Forms.Label();
            this.greetingsTextLabel = new System.Windows.Forms.Label();
            this.groupBoxReg.SuspendLayout();
            this.PasswordTableLayout.SuspendLayout();
            this.EmailTableLayout.SuspendLayout();
            this.nameTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonReg.FlatAppearance.BorderSize = 0;
            this.buttonReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReg.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReg.ForeColor = System.Drawing.Color.Transparent;
            this.buttonReg.Location = new System.Drawing.Point(36, 395);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(389, 56);
            this.buttonReg.TabIndex = 0;
            this.buttonReg.Text = "GET STARTED";
            this.buttonReg.UseVisualStyleBackColor = false;
            // 
            // groupBoxReg
            // 
            this.groupBoxReg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxReg.Controls.Add(this.label1);
            this.groupBoxReg.Controls.Add(this.orAdditionalLabel);
            this.groupBoxReg.Controls.Add(this.orLabel);
            this.groupBoxReg.Controls.Add(this.hintTextPassword);
            this.groupBoxReg.Controls.Add(this.PasswordTableLayout);
            this.groupBoxReg.Controls.Add(this.hintTextEmail);
            this.groupBoxReg.Controls.Add(this.EmailTableLayout);
            this.groupBoxReg.Controls.Add(this.hintTextName);
            this.groupBoxReg.Controls.Add(this.nameTableLayout);
            this.groupBoxReg.Controls.Add(this.greetingsText2);
            this.groupBoxReg.Controls.Add(this.greetingsText1);
            this.groupBoxReg.Controls.Add(this.buttonReg);
            this.groupBoxReg.Location = new System.Drawing.Point(729, 148);
            this.groupBoxReg.Name = "groupBoxReg";
            this.groupBoxReg.Size = new System.Drawing.Size(460, 768);
            this.groupBoxReg.TabIndex = 1;
            this.groupBoxReg.TabStop = false;
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(283, 551);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 56);
            this.label1.TabIndex = 13;
            this.label1.Text = "LOGIN HERE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orAdditionalLabel
            // 
            this.orAdditionalLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orAdditionalLabel.Location = new System.Drawing.Point(66, 551);
            this.orAdditionalLabel.Name = "orAdditionalLabel";
            this.orAdditionalLabel.Size = new System.Drawing.Size(235, 56);
            this.orAdditionalLabel.TabIndex = 12;
            this.orAdditionalLabel.Text = "Already have an account?";
            this.orAdditionalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orLabel
            // 
            this.orLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.orLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orLabel.Location = new System.Drawing.Point(36, 473);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(389, 56);
            this.orLabel.TabIndex = 11;
            this.orLabel.Text = "Or";
            this.orLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hintTextPassword
            // 
            this.hintTextPassword.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hintTextPassword.Location = new System.Drawing.Point(50, 301);
            this.hintTextPassword.Name = "hintTextPassword";
            this.hintTextPassword.Size = new System.Drawing.Size(76, 18);
            this.hintTextPassword.TabIndex = 8;
            this.hintTextPassword.TabStop = false;
            this.hintTextPassword.Text = "Password";
            // 
            // PasswordTableLayout
            // 
            this.PasswordTableLayout.BackColor = System.Drawing.SystemColors.Window;
            this.PasswordTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.PasswordTableLayout.ColumnCount = 1;
            this.PasswordTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PasswordTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PasswordTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PasswordTableLayout.Controls.Add(this.passwordField, 0, 0);
            this.PasswordTableLayout.Location = new System.Drawing.Point(36, 316);
            this.PasswordTableLayout.Name = "PasswordTableLayout";
            this.PasswordTableLayout.RowCount = 1;
            this.PasswordTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PasswordTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PasswordTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PasswordTableLayout.Size = new System.Drawing.Size(389, 56);
            this.PasswordTableLayout.TabIndex = 10;
            // 
            // passwordField
            // 
            this.passwordField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordField.Font = new System.Drawing.Font("Yu Gothic", 15.75F);
            this.passwordField.Location = new System.Drawing.Point(4, 11);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(381, 34);
            this.passwordField.TabIndex = 0;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // hintTextEmail
            // 
            this.hintTextEmail.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hintTextEmail.Location = new System.Drawing.Point(50, 219);
            this.hintTextEmail.Name = "hintTextEmail";
            this.hintTextEmail.Size = new System.Drawing.Size(57, 19);
            this.hintTextEmail.TabIndex = 7;
            this.hintTextEmail.TabStop = false;
            this.hintTextEmail.Text = "Email";
            // 
            // EmailTableLayout
            // 
            this.EmailTableLayout.BackColor = System.Drawing.SystemColors.Window;
            this.EmailTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.EmailTableLayout.ColumnCount = 1;
            this.EmailTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EmailTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EmailTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EmailTableLayout.Controls.Add(this.nameEmail, 0, 0);
            this.EmailTableLayout.Location = new System.Drawing.Point(36, 236);
            this.EmailTableLayout.Name = "EmailTableLayout";
            this.EmailTableLayout.RowCount = 1;
            this.EmailTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EmailTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EmailTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EmailTableLayout.Size = new System.Drawing.Size(389, 56);
            this.EmailTableLayout.TabIndex = 9;
            // 
            // nameEmail
            // 
            this.nameEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameEmail.Font = new System.Drawing.Font("Yu Gothic", 15.75F);
            this.nameEmail.Location = new System.Drawing.Point(4, 11);
            this.nameEmail.Name = "nameEmail";
            this.nameEmail.Size = new System.Drawing.Size(381, 34);
            this.nameEmail.TabIndex = 0;
            // 
            // hintTextName
            // 
            this.hintTextName.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hintTextName.Location = new System.Drawing.Point(50, 144);
            this.hintTextName.Name = "hintTextName";
            this.hintTextName.Size = new System.Drawing.Size(85, 15);
            this.hintTextName.TabIndex = 6;
            this.hintTextName.TabStop = false;
            this.hintTextName.Text = "Your Name";
            // 
            // nameTableLayout
            // 
            this.nameTableLayout.BackColor = System.Drawing.SystemColors.Window;
            this.nameTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.nameTableLayout.ColumnCount = 1;
            this.nameTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.nameTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.nameTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.nameTableLayout.Controls.Add(this.nameField, 0, 0);
            this.nameTableLayout.Location = new System.Drawing.Point(36, 157);
            this.nameTableLayout.Name = "nameTableLayout";
            this.nameTableLayout.RowCount = 1;
            this.nameTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.nameTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.nameTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.nameTableLayout.Size = new System.Drawing.Size(389, 56);
            this.nameTableLayout.TabIndex = 2;
            // 
            // nameField
            // 
            this.nameField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameField.Font = new System.Drawing.Font("Yu Gothic", 15.75F);
            this.nameField.Location = new System.Drawing.Point(4, 11);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(381, 34);
            this.nameField.TabIndex = 0;
            // 
            // greetingsText2
            // 
            this.greetingsText2.Font = new System.Drawing.Font("Yu Gothic Medium", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greetingsText2.Location = new System.Drawing.Point(28, 65);
            this.greetingsText2.Name = "greetingsText2";
            this.greetingsText2.Size = new System.Drawing.Size(349, 44);
            this.greetingsText2.TabIndex = 5;
            this.greetingsText2.Text = "Create an Account";
            // 
            // greetingsText1
            // 
            this.greetingsText1.Font = new System.Drawing.Font("Yu Gothic UI", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greetingsText1.ForeColor = System.Drawing.Color.Black;
            this.greetingsText1.Location = new System.Drawing.Point(35, 33);
            this.greetingsText1.Name = "greetingsText1";
            this.greetingsText1.Size = new System.Drawing.Size(164, 23);
            this.greetingsText1.TabIndex = 4;
            this.greetingsText1.Text = "LET\'S GET STARTED";
            // 
            // greetingsTextLabel
            // 
            this.greetingsTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.greetingsTextLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetingsTextLabel.ForeColor = System.Drawing.Color.Transparent;
            this.greetingsTextLabel.Location = new System.Drawing.Point(250, 432);
            this.greetingsTextLabel.Name = "greetingsTextLabel";
            this.greetingsTextLabel.Size = new System.Drawing.Size(380, 245);
            this.greetingsTextLabel.TabIndex = 2;
            this.greetingsTextLabel.Text = "Explore the world with WeatherMe...\r\n\r\n... your personal weather companion. Recei" +
    "ve personalized recommendations, and stay informed about the conditions that mat" +
    "ter to you. Enjoy your journey!\r\n";
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeatherMeApp.Properties.Resources.background_image_photoaidcom_darken;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1424, 912);
            this.Controls.Add(this.greetingsTextLabel);
            this.Controls.Add(this.groupBoxReg);
            this.MaximizeBox = false;
            this.Name = "registerForm";
            this.Opacity = 0.5D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxReg.ResumeLayout(false);
            this.PasswordTableLayout.ResumeLayout(false);
            this.PasswordTableLayout.PerformLayout();
            this.EmailTableLayout.ResumeLayout(false);
            this.EmailTableLayout.PerformLayout();
            this.nameTableLayout.ResumeLayout(false);
            this.nameTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.GroupBox groupBoxReg;
        private System.Windows.Forms.Label greetingsText2;
        private System.Windows.Forms.Label greetingsText1;
        private System.Windows.Forms.GroupBox hintTextName;
        private System.Windows.Forms.GroupBox hintTextPassword;
        private System.Windows.Forms.GroupBox hintTextEmail;
        private TableLayoutPanel nameTableLayout;
        private TextBox nameField;
        private TableLayoutPanel PasswordTableLayout;
        private TextBox passwordField;
        private TableLayoutPanel EmailTableLayout;
        private TextBox nameEmail;
        private Label orLabel;
        private Label orAdditionalLabel;
        private Label label1;
        private Label greetingsTextLabel;
    }
}

