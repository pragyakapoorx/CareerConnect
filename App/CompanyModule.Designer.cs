namespace WinFormsApp1
{
    partial class CompanyModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyModule));
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            comboBox2 = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(310, 287);
            button1.Name = "button1";
            button1.Size = new Size(101, 31);
            button1.TabIndex = 0;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(358, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 30);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(284, 20);
            label1.Name = "label1";
            label1.Size = new Size(142, 26);
            label1.TabIndex = 2;
            label1.Text = "Company Module";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(240, 71);
            label2.Name = "label2";
            label2.Size = new Size(105, 23);
            label2.TabIndex = 3;
            label2.Text = "Company ID";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(214, 108);
            label3.Name = "label3";
            label3.Size = new Size(134, 23);
            label3.TabIndex = 4;
            label3.Text = "Company Name";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(272, 144);
            label4.Name = "label4";
            label4.Size = new Size(72, 23);
            label4.TabIndex = 5;
            label4.Text = "Industry";
            label4.Click += label4_Click;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(358, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(135, 30);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(358, 225);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(72, 30);
            textBox3.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "IT", "Finance", "Health Care", "Education" });
            comboBox1.Location = new Point(358, 144);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(134, 31);
            comboBox1.TabIndex = 8;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(270, 188);
            label5.Name = "label5";
            label5.Size = new Size(75, 23);
            label5.TabIndex = 9;
            label5.Text = "Location";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.None;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Delhi", "Bengaluru", "Chennai", "Pune" });
            comboBox2.Location = new Point(358, 185);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(134, 31);
            comboBox2.TabIndex = 10;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(223, 225);
            label6.Name = "label6";
            label6.Size = new Size(124, 23);
            label6.TabIndex = 11;
            label6.Text = "Response Time";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(447, 231);
            label7.Name = "label7";
            label7.Size = new Size(44, 23);
            label7.TabIndex = 12;
            label7.Text = "days";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(720, 414);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "Form3";
            Text = "Company Module";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Label label5;
        private ComboBox comboBox2;
        private Label label6;
        private Label label7;
    }
}