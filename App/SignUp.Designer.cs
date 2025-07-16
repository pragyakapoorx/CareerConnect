namespace WinFormsApp1
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            label7 = new Label();
            textBox2 = new TextBox();
            textBox5 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(144, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 30);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(144, 136);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(135, 30);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Location = new Point(144, 91);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(135, 30);
            textBox4.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(44, 51);
            label1.Name = "label1";
            label1.Size = new Size(61, 23);
            label1.TabIndex = 4;
            label1.Text = "UserID";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(15, 97);
            label2.Name = "label2";
            label2.Size = new Size(92, 23);
            label2.TabIndex = 5;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(17, 142);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 6;
            label3.Text = "Last Name";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(404, 74);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(270, 30);
            dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(489, 48);
            label4.Name = "label4";
            label4.Size = new Size(107, 23);
            label4.TabIndex = 8;
            label4.Text = "Date of Birth";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(40, 186);
            label5.Name = "label5";
            label5.Size = new Size(66, 23);
            label5.TabIndex = 9;
            label5.Text = "Gender";
            label5.Click += label5_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(144, 183);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(135, 31);
            comboBox1.TabIndex = 10;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = SystemColors.GradientActiveCaption;
            label6.Location = new Point(464, 167);
            label6.Name = "label6";
            label6.Size = new Size(43, 23);
            label6.TabIndex = 11;
            label6.Text = "Role";
            // 
            // radioButton1
            // 
            radioButton1.Anchor = AnchorStyles.None;
            radioButton1.AutoSize = true;
            radioButton1.BackColor = SystemColors.GradientActiveCaption;
            radioButton1.Location = new Point(518, 145);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(112, 27);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "Job Seeker";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.Anchor = AnchorStyles.None;
            radioButton2.AutoSize = true;
            radioButton2.BackColor = SystemColors.GradientActiveCaption;
            radioButton2.Location = new Point(518, 192);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(102, 27);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "Employer";
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(294, 324);
            button1.Name = "button1";
            button1.Size = new Size(101, 31);
            button1.TabIndex = 14;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(404, 244);
            label7.Name = "label7";
            label7.Size = new Size(105, 23);
            label7.TabIndex = 15;
            label7.Text = "Company ID";
            label7.Visible = false;
            label7.Click += label7_Click;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(518, 244);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(135, 30);
            textBox2.TabIndex = 16;
            textBox2.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.Location = new Point(144, 278);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(135, 30);
            textBox5.TabIndex = 17;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(27, 281);
            label8.Name = "label8";
            label8.Size = new Size(80, 23);
            label8.TabIndex = 18;
            label8.Text = "Password";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(44, 234);
            label9.Name = "label9";
            label9.Size = new Size(51, 23);
            label9.TabIndex = 19;
            label9.Text = "Email";
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.None;
            textBox6.Location = new Point(144, 231);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(135, 30);
            textBox6.TabIndex = 20;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(720, 414);
            Controls.Add(textBox6);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            DoubleBuffered = true;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private Label label7;
        private TextBox textBox2;
        private TextBox textBox5;
        private Label label8;
        private Label label9;
        private TextBox textBox6;
    }
}