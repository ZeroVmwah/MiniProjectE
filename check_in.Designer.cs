namespace MiniProjectE
{
    partial class check_in
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            numberDishes = new TextBox();
            clientName = new TextBox();
            phoneNumber = new TextBox();
            bill = new TextBox();
            orderDate = new TextBox();
            label6 = new Label();
            reserve = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 124);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 0;
            label1.Text = "Number of dishes ordered:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(398, 124);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Your name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 230);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 2;
            label3.Text = "Your phone number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(398, 230);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 3;
            label4.Text = "Bill total:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(264, 315);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 4;
            label5.Text = "Date of order:";
            // 
            // numberDishes
            // 
            numberDishes.Location = new Point(128, 142);
            numberDishes.Name = "numberDishes";
            numberDishes.Size = new Size(100, 23);
            numberDishes.TabIndex = 5;
            // 
            // clientName
            // 
            clientName.Location = new Point(398, 142);
            clientName.Name = "clientName";
            clientName.Size = new Size(100, 23);
            clientName.TabIndex = 6;
            clientName.Validating += clientName_Validating;
            // 
            // phoneNumber
            // 
            phoneNumber.Location = new Point(128, 248);
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Size = new Size(100, 23);
            phoneNumber.TabIndex = 7;
            phoneNumber.Validating += phoneNumber_Validating;
            // 
            // bill
            // 
            bill.Location = new Point(398, 248);
            bill.Name = "bill";
            bill.Size = new Size(100, 23);
            bill.TabIndex = 8;
            bill.Validating += bill_Validating;
            // 
            // orderDate
            // 
            orderDate.Location = new Point(264, 333);
            orderDate.Name = "orderDate";
            orderDate.Size = new Size(100, 23);
            orderDate.TabIndex = 9;
            orderDate.Validating += orderDate_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(214, 42);
            label6.Name = "label6";
            label6.Size = new Size(171, 32);
            label6.TabIndex = 10;
            label6.Text = "Placing Order";
            // 
            // reserve
            // 
            reserve.Location = new Point(128, 394);
            reserve.Name = "reserve";
            reserve.Size = new Size(75, 23);
            reserve.TabIndex = 11;
            reserve.Text = "Order";
            reserve.UseVisualStyleBackColor = true;
            reserve.Click += reserve_Click;
            // 
            // button1
            // 
            button1.Location = new Point(268, 394);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(423, 394);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // check_in
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(614, 441);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(reserve);
            Controls.Add(label6);
            Controls.Add(orderDate);
            Controls.Add(bill);
            Controls.Add(phoneNumber);
            Controls.Add(clientName);
            Controls.Add(numberDishes);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "check_in";
            Text = "check_in";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox numberDishes;
        private TextBox clientName;
        private TextBox phoneNumber;
        private TextBox bill;
        private TextBox orderDate;
        private Label label6;
        private Button reserve;
        private Button button1;
        private Button button2;
    }
}