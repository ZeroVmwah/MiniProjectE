namespace MiniProjectE
{
    partial class Filter
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
            course = new ComboBox();
            diet = new ComboBox();
            allergies = new ComboBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            clear = new Button();
            checkIn = new Button();
            psize = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // course
            // 
            course.FormattingEnabled = true;
            course.Items.AddRange(new object[] { "Appetizer", "Main", "Dessert" });
            course.Location = new Point(27, 139);
            course.Name = "course";
            course.Size = new Size(121, 23);
            course.TabIndex = 0;
            course.SelectedIndexChanged += course_SelectedIndexChanged;
            // 
            // diet
            // 
            diet.FormattingEnabled = true;
            diet.Items.AddRange(new object[] { "Vegan", "Vegetarian", "Pescatarian", "None" });
            diet.Location = new Point(187, 139);
            diet.Name = "diet";
            diet.Size = new Size(121, 23);
            diet.TabIndex = 1;
            diet.SelectedIndexChanged += diet_SelectedIndexChanged;
            // 
            // allergies
            // 
            allergies.FormattingEnabled = true;
            allergies.Items.AddRange(new object[] { "Nut", "Dairy", "Gluten", "None" });
            allergies.Location = new Point(348, 139);
            allergies.Name = "allergies";
            allergies.Size = new Size(121, 23);
            allergies.TabIndex = 2;
            allergies.SelectedIndexChanged += allergies_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(81, 210);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(497, 150);
            dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(141, 44);
            label1.Name = "label1";
            label1.Size = new Size(370, 46);
            label1.TabIndex = 4;
            label1.Text = "Restaurant Pochivka";
            // 
            // clear
            // 
            clear.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point);
            clear.Location = new Point(187, 394);
            clear.Name = "clear";
            clear.Size = new Size(75, 32);
            clear.TabIndex = 5;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // checkIn
            // 
            checkIn.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkIn.Location = new Point(363, 394);
            checkIn.Name = "checkIn";
            checkIn.Size = new Size(106, 32);
            checkIn.TabIndex = 6;
            checkIn.Text = "Place order";
            checkIn.UseVisualStyleBackColor = true;
            checkIn.Click += checkIn_Click;
            // 
            // psize
            // 
            psize.FormattingEnabled = true;
            psize.Items.AddRange(new object[] { "Small", "Medium", "Large" });
            psize.Location = new Point(506, 139);
            psize.Name = "psize";
            psize.Size = new Size(121, 23);
            psize.TabIndex = 7;
            psize.SelectedIndexChanged += psize_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 121);
            label2.Name = "label2";
            label2.Size = new Size(82, 17);
            label2.TabIndex = 8;
            label2.Text = "Filter course:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(187, 121);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 9;
            label3.Text = "Filter diet:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(348, 121);
            label4.Name = "label4";
            label4.Size = new Size(91, 17);
            label4.TabIndex = 10;
            label4.Text = "Filter allergies:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(506, 121);
            label5.Name = "label5";
            label5.Size = new Size(114, 17);
            label5.TabIndex = 11;
            label5.Text = "Filter portion size:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(657, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(psize);
            Controls.Add(checkIn);
            Controls.Add(clear);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(allergies);
            Controls.Add(diet);
            Controls.Add(course);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox course;
        private ComboBox diet;
        private ComboBox allergies;
        private DataGridView dataGridView1;
        private Label label1;
        private Button clear;
        private Button checkIn;
        private ComboBox psize;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}