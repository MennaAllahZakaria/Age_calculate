namespace age
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
            input = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            year = new Label();
            month = new Label();
            day = new Label();
            button1 = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // input
            // 
            input.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            input.Location = new Point(362, 119);
            input.Name = "input";
            input.Size = new Size(228, 43);
            input.TabIndex = 0;
            input.TextChanged += input_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 255);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(43, 119);
            label1.Name = "label1";
            label1.Size = new Size(195, 40);
            label1.TabIndex = 1;
            label1.Text = "Enter the days";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Fuchsia;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(104, 274);
            label2.Name = "label2";
            label2.Size = new Size(83, 46);
            label2.TabIndex = 2;
            label2.Text = "Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Fuchsia;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(304, 274);
            label3.Name = "label3";
            label3.Size = new Size(119, 46);
            label3.TabIndex = 3;
            label3.Text = "month";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Fuchsia;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(543, 274);
            label4.Name = "label4";
            label4.Size = new Size(73, 46);
            label4.TabIndex = 4;
            label4.Text = "day";
            // 
            // year
            // 
            year.AutoSize = true;
            year.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            year.Location = new Point(104, 357);
            year.Name = "year";
            year.Size = new Size(47, 38);
            year.TabIndex = 5;
            year.Text = "00";
            year.Click += label5_Click;
            // 
            // month
            // 
            month.AutoSize = true;
            month.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            month.Location = new Point(331, 353);
            month.Name = "month";
            month.Size = new Size(47, 38);
            month.TabIndex = 6;
            month.Text = "00";
            month.Click += label6_Click;
            // 
            // day
            // 
            day.AutoSize = true;
            day.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            day.Location = new Point(543, 353);
            day.Name = "day";
            day.Size = new Size(47, 38);
            day.TabIndex = 7;
            day.Text = "00";
            day.Click += label7_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Purple;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(224, 224, 224);
            button1.Location = new Point(261, 181);
            button1.Name = "button1";
            button1.Size = new Size(196, 67);
            button1.TabIndex = 8;
            button1.Text = "Get Age";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(255, 192, 255);
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 23);
            label8.Name = "label8";
            label8.Size = new Size(1170, 41);
            label8.TabIndex = 9;
            label8.Text = "this program is to claculate the years and months and dayes of total dayes you entered";
            label8.Click += label8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(940, 450);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(day);
            Controls.Add(month);
            Controls.Add(year);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(input);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox input;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label year;
        private Label month;
        private Label day;
        private Button button1;
        private Label label8;
    }
}