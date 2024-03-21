namespace MiniProjectE
{
    partial class Form2
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
            password = new Label();
            loginpassword = new TextBox();
            Username = new Label();
            name = new TextBox();
            label1 = new Label();
            Si = new Button();
            SuspendLayout();
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(119, 219);
            password.Name = "password";
            password.Size = new Size(57, 15);
            password.TabIndex = 14;
            password.Text = "Password";
            // 
            // loginpassword
            // 
            loginpassword.Location = new Point(119, 234);
            loginpassword.Margin = new Padding(3, 2, 3, 2);
            loginpassword.Name = "loginpassword";
            loginpassword.PasswordChar = '*';
            loginpassword.Size = new Size(86, 23);
            loginpassword.TabIndex = 13;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(119, 130);
            Username.Name = "Username";
            Username.Size = new Size(60, 15);
            Username.TabIndex = 10;
            Username.Text = "Username";
            // 
            // name
            // 
            name.Location = new Point(119, 145);
            name.Margin = new Padding(3, 2, 3, 2);
            name.Name = "name";
            name.Size = new Size(86, 23);
            name.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(119, 37);
            label1.Name = "label1";
            label1.Size = new Size(120, 21);
            label1.TabIndex = 8;
            label1.Text = "Login Form";
            // 
            // Si
            // 
            Si.BackColor = Color.MediumSeaGreen;
            Si.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Si.Location = new Point(141, 400);
            Si.Margin = new Padding(3, 2, 3, 2);
            Si.Name = "Si";
            Si.Size = new Size(64, 18);
            Si.TabIndex = 15;
            Si.Text = "Sumbit";
            Si.UseVisualStyleBackColor = false;
            Si.Click += Si_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(383, 471);
            Controls.Add(Si);
            Controls.Add(password);
            Controls.Add(loginpassword);
            Controls.Add(Username);
            Controls.Add(name);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label password;
        private TextBox loginpassword;
        private Label Username;
        private TextBox name;
        private Label label1;
        private Button Si;
    }
}