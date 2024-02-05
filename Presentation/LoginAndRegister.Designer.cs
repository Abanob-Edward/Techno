
namespace Presentation
{
    partial class LoginAndRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAndRegister));
            button_GoToLogin = new Button();
            button_GoTo_Register = new Button();
            panel_login = new Panel();
            label_log_suc = new Label();
            label_error_mas_log = new Label();
            button_Login = new Button();
            textBox_Pss_login = new TextBox();
            label_Pass_login = new Label();
            textBox_UName_Login = new TextBox();
            label_UName_login = new Label();
            pictureBox1_close = new PictureBox();
            panel_register = new Panel();
            label_User_regis = new Label();
            label_ErrorMas = new Label();
            textBox_eimal = new TextBox();
            label_Eimal = new Label();
            label_PNmber = new Label();
            textBox_Phone_Number = new TextBox();
            label_UName = new Label();
            textBox_FName = new TextBox();
            label_FName = new Label();
            textBox_Confirm_Pass = new TextBox();
            label_Confirm_Pass = new Label();
            textBox_Pass = new TextBox();
            label_Pass = new Label();
            button_Register = new Button();
            textBox_UName = new TextBox();
            label11 = new Label();
            textBox_LName = new TextBox();
            label_LName = new Label();
            panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_close).BeginInit();
            panel_register.SuspendLayout();
            SuspendLayout();
            // 
            // button_GoToLogin
            // 
            button_GoToLogin.BackColor = Color.FromArgb(214, 90, 49);
            button_GoToLogin.FlatAppearance.BorderColor = Color.Black;
            button_GoToLogin.FlatStyle = FlatStyle.Flat;
            button_GoToLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_GoToLogin.ForeColor = Color.WhiteSmoke;
            button_GoToLogin.Location = new Point(12, 40);
            button_GoToLogin.Name = "button_GoToLogin";
            button_GoToLogin.Size = new Size(220, 66);
            button_GoToLogin.TabIndex = 0;
            button_GoToLogin.Text = "Login";
            button_GoToLogin.UseVisualStyleBackColor = false;
            button_GoToLogin.Click += button_GoToLogin_Click;
            // 
            // button_GoTo_Register
            // 
            button_GoTo_Register.BackColor = Color.FromArgb(214, 90, 49);
            button_GoTo_Register.FlatAppearance.BorderColor = Color.Black;
            button_GoTo_Register.FlatStyle = FlatStyle.Flat;
            button_GoTo_Register.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_GoTo_Register.ForeColor = Color.WhiteSmoke;
            button_GoTo_Register.Location = new Point(321, 40);
            button_GoTo_Register.Name = "button_GoTo_Register";
            button_GoTo_Register.Size = new Size(220, 69);
            button_GoTo_Register.TabIndex = 1;
            button_GoTo_Register.Text = "Register";
            button_GoTo_Register.UseVisualStyleBackColor = false;
            button_GoTo_Register.Click += button_GoTo_Register_Click;
            // 
            // panel_login
            // 
            panel_login.Controls.Add(label_log_suc);
            panel_login.Controls.Add(label_error_mas_log);
            panel_login.Controls.Add(button_Login);
            panel_login.Controls.Add(textBox_Pss_login);
            panel_login.Controls.Add(label_Pass_login);
            panel_login.Controls.Add(textBox_UName_Login);
            panel_login.Controls.Add(label_UName_login);
            panel_login.Location = new Point(7, 123);
            panel_login.Name = "panel_login";
            panel_login.Size = new Size(573, 517);
            panel_login.TabIndex = 2;
            panel_login.Paint += panel_login_Paint;
            // 
            // label_log_suc
            // 
            label_log_suc.AutoSize = true;
            label_log_suc.BackColor = Color.Black;
            label_log_suc.Font = new Font("Simplified Arabic Fixed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_log_suc.ForeColor = Color.Lime;
            label_log_suc.Location = new Point(174, 11);
            label_log_suc.Name = "label_log_suc";
            label_log_suc.Size = new Size(0, 34);
            label_log_suc.TabIndex = 18;
            // 
            // label_error_mas_log
            // 
            label_error_mas_log.AutoSize = true;
            label_error_mas_log.BackColor = Color.Black;
            label_error_mas_log.Font = new Font("Simplified Arabic Fixed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_error_mas_log.ForeColor = Color.Red;
            label_error_mas_log.Location = new Point(18, 13);
            label_error_mas_log.Name = "label_error_mas_log";
            label_error_mas_log.Size = new Size(0, 28);
            label_error_mas_log.TabIndex = 17;
            // 
            // button_Login
            // 
            button_Login.FlatStyle = FlatStyle.Flat;
            button_Login.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Login.ForeColor = Color.White;
            button_Login.Location = new Point(90, 279);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(443, 40);
            button_Login.TabIndex = 4;
            button_Login.Text = "Login";
            button_Login.UseVisualStyleBackColor = true;
            button_Login.Click += button_Login_Click;
            // 
            // textBox_Pss_login
            // 
            textBox_Pss_login.Location = new Point(205, 161);
            textBox_Pss_login.Name = "textBox_Pss_login";
            textBox_Pss_login.Size = new Size(334, 27);
            textBox_Pss_login.TabIndex = 3;
            textBox_Pss_login.UseSystemPasswordChar = true;
            // 
            // label_Pass_login
            // 
            label_Pass_login.AutoSize = true;
            label_Pass_login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Pass_login.ForeColor = Color.White;
            label_Pass_login.Location = new Point(96, 160);
            label_Pass_login.Name = "label_Pass_login";
            label_Pass_login.Size = new Size(97, 28);
            label_Pass_login.TabIndex = 2;
            label_Pass_login.Text = "Password:";
            // 
            // textBox_UName_Login
            // 
            textBox_UName_Login.Location = new Point(205, 91);
            textBox_UName_Login.Name = "textBox_UName_Login";
            textBox_UName_Login.Size = new Size(334, 27);
            textBox_UName_Login.TabIndex = 1;
            // 
            // label_UName_login
            // 
            label_UName_login.AutoSize = true;
            label_UName_login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_UName_login.ForeColor = Color.White;
            label_UName_login.Location = new Point(96, 90);
            label_UName_login.Name = "label_UName_login";
            label_UName_login.Size = new Size(107, 28);
            label_UName_login.TabIndex = 0;
            label_UName_login.Text = "UserName:";
            // 
            // pictureBox1_close
            // 
            pictureBox1_close.ErrorImage = (Image)resources.GetObject("pictureBox1_close.ErrorImage");
            pictureBox1_close.ImageLocation = "../ ../images/x.png";
            pictureBox1_close.InitialImage = (Image)resources.GetObject("pictureBox1_close.InitialImage");
            pictureBox1_close.Location = new Point(525, 12);
            pictureBox1_close.Name = "pictureBox1_close";
            pictureBox1_close.Size = new Size(16, 16);
            pictureBox1_close.TabIndex = 3;
            pictureBox1_close.TabStop = false;
            pictureBox1_close.Click += pictureBox1_close_Click;
            // 
            // panel_register
            // 
            panel_register.Controls.Add(label_User_regis);
            panel_register.Controls.Add(label_ErrorMas);
            panel_register.Controls.Add(textBox_eimal);
            panel_register.Controls.Add(label_Eimal);
            panel_register.Controls.Add(label_PNmber);
            panel_register.Controls.Add(textBox_Phone_Number);
            panel_register.Controls.Add(label_UName);
            panel_register.Controls.Add(textBox_FName);
            panel_register.Controls.Add(label_FName);
            panel_register.Controls.Add(textBox_Confirm_Pass);
            panel_register.Controls.Add(label_Confirm_Pass);
            panel_register.Controls.Add(textBox_Pass);
            panel_register.Controls.Add(label_Pass);
            panel_register.Controls.Add(button_Register);
            panel_register.Controls.Add(textBox_UName);
            panel_register.Controls.Add(label11);
            panel_register.Controls.Add(textBox_LName);
            panel_register.Controls.Add(label_LName);
            panel_register.Location = new Point(25, 136);
            panel_register.Name = "panel_register";
            panel_register.Size = new Size(547, 504);
            panel_register.TabIndex = 6;
            panel_register.Paint += panel_register_Paint;
            // 
            // label_User_regis
            // 
            label_User_regis.AutoSize = true;
            label_User_regis.BackColor = Color.Black;
            label_User_regis.Font = new Font("Simplified Arabic Fixed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_User_regis.ForeColor = Color.Lime;
            label_User_regis.Location = new Point(90, 11);
            label_User_regis.Name = "label_User_regis";
            label_User_regis.Size = new Size(0, 28);
            label_User_regis.TabIndex = 17;
            // 
            // label_ErrorMas
            // 
            label_ErrorMas.AutoSize = true;
            label_ErrorMas.BackColor = Color.Black;
            label_ErrorMas.Font = new Font("Simplified Arabic Fixed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_ErrorMas.ForeColor = Color.Red;
            label_ErrorMas.Location = new Point(37, 14);
            label_ErrorMas.Name = "label_ErrorMas";
            label_ErrorMas.Size = new Size(0, 23);
            label_ErrorMas.TabIndex = 16;
            // 
            // textBox_eimal
            // 
            textBox_eimal.BackColor = Color.FromArgb(238, 238, 238);
            textBox_eimal.Location = new Point(206, 263);
            textBox_eimal.Name = "textBox_eimal";
            textBox_eimal.Size = new Size(334, 27);
            textBox_eimal.TabIndex = 15;
            textBox_eimal.TextChanged += textBox1_eimal_TextChanged;
            // 
            // label_Eimal
            // 
            label_Eimal.AutoSize = true;
            label_Eimal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Eimal.ForeColor = Color.FromArgb(214, 90, 49);
            label_Eimal.Location = new Point(19, 259);
            label_Eimal.Name = "label_Eimal";
            label_Eimal.Size = new Size(78, 28);
            label_Eimal.TabIndex = 14;
            label_Eimal.Text = "Eimal  : ";
            // 
            // label_PNmber
            // 
            label_PNmber.AutoSize = true;
            label_PNmber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_PNmber.ForeColor = Color.FromArgb(214, 90, 49);
            label_PNmber.Location = new Point(19, 209);
            label_PNmber.Name = "label_PNmber";
            label_PNmber.Size = new Size(158, 28);
            label_PNmber.TabIndex = 13;
            label_PNmber.Text = "Phone Number : ";
            // 
            // textBox_Phone_Number
            // 
            textBox_Phone_Number.BackColor = Color.FromArgb(238, 238, 238);
            textBox_Phone_Number.Location = new Point(206, 210);
            textBox_Phone_Number.Name = "textBox_Phone_Number";
            textBox_Phone_Number.Size = new Size(334, 27);
            textBox_Phone_Number.TabIndex = 12;
            textBox_Phone_Number.TextChanged += Phone_Number_TextChanged;
            // 
            // label_UName
            // 
            label_UName.AutoSize = true;
            label_UName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_UName.ForeColor = Color.FromArgb(214, 90, 49);
            label_UName.Location = new Point(19, 163);
            label_UName.Name = "label_UName";
            label_UName.Size = new Size(117, 28);
            label_UName.TabIndex = 11;
            label_UName.Text = "UserName : ";
            // 
            // textBox_FName
            // 
            textBox_FName.BackColor = Color.FromArgb(238, 238, 238);
            textBox_FName.Location = new Point(206, 67);
            textBox_FName.Name = "textBox_FName";
            textBox_FName.Size = new Size(334, 27);
            textBox_FName.TabIndex = 10;
            // 
            // label_FName
            // 
            label_FName.AutoSize = true;
            label_FName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_FName.ForeColor = Color.FromArgb(214, 90, 49);
            label_FName.Location = new Point(19, 66);
            label_FName.Name = "label_FName";
            label_FName.Size = new Size(125, 28);
            label_FName.TabIndex = 9;
            label_FName.Text = "First Name  : ";
            label_FName.Click += label_FName_Click;
            // 
            // textBox_Confirm_Pass
            // 
            textBox_Confirm_Pass.BackColor = Color.FromArgb(238, 238, 238);
            textBox_Confirm_Pass.Location = new Point(206, 351);
            textBox_Confirm_Pass.Name = "textBox_Confirm_Pass";
            textBox_Confirm_Pass.Size = new Size(334, 27);
            textBox_Confirm_Pass.TabIndex = 8;
            textBox_Confirm_Pass.UseSystemPasswordChar = true;
            // 
            // label_Confirm_Pass
            // 
            label_Confirm_Pass.AutoSize = true;
            label_Confirm_Pass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Confirm_Pass.ForeColor = Color.FromArgb(214, 90, 49);
            label_Confirm_Pass.Location = new Point(19, 350);
            label_Confirm_Pass.Name = "label_Confirm_Pass";
            label_Confirm_Pass.Size = new Size(182, 28);
            label_Confirm_Pass.TabIndex = 7;
            label_Confirm_Pass.Text = "Confirm Password : ";
            // 
            // textBox_Pass
            // 
            textBox_Pass.BackColor = Color.FromArgb(238, 238, 238);
            textBox_Pass.Location = new Point(206, 310);
            textBox_Pass.Name = "textBox_Pass";
            textBox_Pass.Size = new Size(334, 27);
            textBox_Pass.TabIndex = 6;
            textBox_Pass.UseSystemPasswordChar = true;
            // 
            // label_Pass
            // 
            label_Pass.AutoSize = true;
            label_Pass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Pass.ForeColor = Color.FromArgb(214, 90, 49);
            label_Pass.Location = new Point(19, 306);
            label_Pass.Name = "label_Pass";
            label_Pass.Size = new Size(107, 28);
            label_Pass.TabIndex = 5;
            label_Pass.Text = "Password : ";
            // 
            // button_Register
            // 
            button_Register.FlatStyle = FlatStyle.Flat;
            button_Register.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Register.ForeColor = Color.FromArgb(214, 90, 49);
            button_Register.Location = new Point(60, 433);
            button_Register.Name = "button_Register";
            button_Register.Size = new Size(443, 40);
            button_Register.TabIndex = 4;
            button_Register.Text = "Register";
            button_Register.UseVisualStyleBackColor = true;
            button_Register.Click += buttonٌُ_ٌRegister_Click;
            // 
            // textBox_UName
            // 
            textBox_UName.BackColor = Color.FromArgb(238, 238, 238);
            textBox_UName.Location = new Point(206, 167);
            textBox_UName.Name = "textBox_UName";
            textBox_UName.Size = new Size(334, 27);
            textBox_UName.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(19, 181);
            label11.Name = "label11";
            label11.Size = new Size(17, 28);
            label11.TabIndex = 2;
            label11.Text = " ";
            // 
            // textBox_LName
            // 
            textBox_LName.BackColor = Color.FromArgb(238, 238, 238);
            textBox_LName.Location = new Point(206, 118);
            textBox_LName.Name = "textBox_LName";
            textBox_LName.Size = new Size(334, 27);
            textBox_LName.TabIndex = 1;
            // 
            // label_LName
            // 
            label_LName.AutoSize = true;
            label_LName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_LName.ForeColor = Color.FromArgb(214, 90, 49);
            label_LName.Location = new Point(19, 114);
            label_LName.Name = "label_LName";
            label_LName.Size = new Size(122, 28);
            label_LName.TabIndex = 0;
            label_LName.Text = "Last Name  : ";
            // 
            // LoginAndRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            ClientSize = new Size(584, 677);
            Controls.Add(pictureBox1_close);
            Controls.Add(button_GoTo_Register);
            Controls.Add(button_GoToLogin);
            Controls.Add(panel_login);
            Controls.Add(panel_register);
            ForeColor = Color.FromArgb(34, 40, 49);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginAndRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            panel_login.ResumeLayout(false);
            panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_close).EndInit();
            panel_register.ResumeLayout(false);
            panel_register.PerformLayout();
            ResumeLayout(false);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button button_GoToLogin;
        private Button button_GoTo_Register;
        private Panel panel_login;
        private Label label_UName_login;
        private TextBox textBox_Pss_login;
        private Label label_Pass_login;
        private TextBox textBox_UName_Login;
        private Button button_Login;
        private PictureBox pictureBox1_close;
        private Panel panel_register;
        private TextBox textBox_FName;
        private Label label_FName;
        private TextBox textBox_Confirm_Pass;
        private Label label_Confirm_Pass;
        private TextBox textBox_Pass;
        private Label label_Pass;
        private Button button_Register;
        private TextBox textBox_UName;
        private Label label11;
        private TextBox textBox_LName;
        private Label label_LName;
        private Label label_UName;
        private Label label_PNmber;
        private TextBox textBox_Phone_Number;
        private TextBox textBox_eimal;
        private Label label_Eimal;
        private Label label_ErrorMas;
        private Label label_error_mas_log;
        private Label label_log_suc;
        private Label label_User_regis;
    }
}