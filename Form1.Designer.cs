namespace MiniProjectE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            name = new TextBox();
            button1 = new Button();
            Username = new Label();
            email = new Label();
            mail = new TextBox();
            password = new Label();
            mypassword = new TextBox();
            label2 = new Label();
            repassword = new TextBox();
            length = new Label();
            capital = new Label();
            number = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            listBox1 = new ListBox();
            label4 = new Label();
            label5 = new Label();
            phone = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(182, 35);
            label1.Name = "label1";
            label1.Size = new Size(175, 21);
            label1.TabIndex = 0;
            label1.Text = "Validation Form";
            // 
            // name
            // 
            name.Location = new Point(96, 102);
            name.Margin = new Padding(3, 2, 3, 2);
            name.Name = "name";
            name.Size = new Size(86, 21);
            name.TabIndex = 1;
            name.Validating += name_Validating;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(221, 468);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 27);
            button1.TabIndex = 2;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(96, 87);
            Username.Name = "Username";
            Username.Size = new Size(53, 12);
            Username.TabIndex = 3;
            Username.Text = "Username";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(96, 141);
            email.Name = "email";
            email.Size = new Size(41, 12);
            email.TabIndex = 5;
            email.Text = "E-mail";
            // 
            // mail
            // 
            mail.Location = new Point(96, 155);
            mail.Margin = new Padding(3, 2, 3, 2);
            mail.Name = "mail";
            mail.Size = new Size(86, 21);
            mail.TabIndex = 4;
            mail.Validating += mail_Validating;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(96, 199);
            password.Name = "password";
            password.Size = new Size(53, 12);
            password.TabIndex = 7;
            password.Text = "Password";
            // 
            // mypassword
            // 
            mypassword.Location = new Point(96, 214);
            mypassword.Margin = new Padding(3, 2, 3, 2);
            mypassword.Name = "mypassword";
            mypassword.PasswordChar = '*';
            mypassword.Size = new Size(86, 21);
            mypassword.TabIndex = 6;
            mypassword.TextChanged += mypassword_TextChanged;
            mypassword.Validating += mypassword_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 259);
            label2.Name = "label2";
            label2.Size = new Size(95, 12);
            label2.TabIndex = 9;
            label2.Text = "Retype password";
            // 
            // repassword
            // 
            repassword.Location = new Point(96, 274);
            repassword.Margin = new Padding(3, 2, 3, 2);
            repassword.Name = "repassword";
            repassword.PasswordChar = '*';
            repassword.Size = new Size(86, 21);
            repassword.TabIndex = 8;
            repassword.Validating += repassword_Validating;
            // 
            // length
            // 
            length.AutoSize = true;
            length.Font = new Font("SimSun", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            length.Location = new Point(194, 199);
            length.Name = "length";
            length.Size = new Size(195, 9);
            length.TabIndex = 10;
            length.Text = "should include more than 8 characters.";
            length.Visible = false;
            // 
            // capital
            // 
            capital.AutoSize = true;
            capital.Font = new Font("SimSun", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            capital.Location = new Point(194, 219);
            capital.Name = "capital";
            capital.Size = new Size(215, 9);
            capital.TabIndex = 11;
            capital.Text = "should include at least one capital letter";
            capital.Visible = false;
            // 
            // number
            // 
            number.AutoSize = true;
            number.Font = new Font("SimSun", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            number.Location = new Point(194, 239);
            number.Name = "number";
            number.Size = new Size(180, 9);
            number.TabIndex = 12;
            number.Text = "should include at least one number.";
            number.Visible = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(96, 326);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.MaxDate = new DateTime(2024, 1, 15, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(225, 21);
            dateTimePicker1.TabIndex = 13;
            dateTimePicker1.Value = new DateTime(2006, 1, 15, 0, 0, 0, 0);
            dateTimePicker1.Validating += dateTimePicker1_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 311);
            label3.Name = "label3";
            label3.Size = new Size(83, 12);
            label3.TabIndex = 14;
            label3.Text = "Date of Birth";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 12;
            listBox1.Items.AddRange(new object[] { "female", "male", "other", "prefer not to say" });
            listBox1.Location = new Point(96, 368);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(103, 16);
            listBox1.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 354);
            label4.Name = "label4";
            label4.Size = new Size(41, 12);
            label4.TabIndex = 16;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(96, 399);
            label5.Name = "label5";
            label5.Size = new Size(77, 12);
            label5.TabIndex = 17;
            label5.Text = "Phone number";
            // 
            // phone
            // 
            phone.Location = new Point(96, 413);
            phone.Margin = new Padding(3, 2, 3, 2);
            phone.Name = "phone";
            phone.Size = new Size(86, 21);
            phone.TabIndex = 18;
            phone.Validating += phone_Validating;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(506, 534);
            Controls.Add(phone);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(number);
            Controls.Add(capital);
            Controls.Add(length);
            Controls.Add(label2);
            Controls.Add(repassword);
            Controls.Add(password);
            Controls.Add(mypassword);
            Controls.Add(email);
            Controls.Add(mail);
            Controls.Add(Username);
            Controls.Add(button1);
            Controls.Add(name);
            Controls.Add(label1);
            Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox name;
        private Button button1;
        private Label Username;
        private Label email;
        private TextBox mail;
        private Label password;
        private TextBox mypassword;
        private Label label2;
        private TextBox repassword;
        private Label length;
        private Label capital;
        private Label number;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private ListBox listBox1;
        private Label label4;
        private Label label5;
        private TextBox phone;
    }
}