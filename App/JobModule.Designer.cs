namespace WinFormsApp1
{
    partial class JobModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobModule));
            label6 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBox6 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(235, 288);
            label6.Name = "label6";
            label6.Size = new Size(96, 23);
            label6.TabIndex = 24;
            label6.Text = "Description";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(311, 202);
            label5.Name = "label5";
            label5.Size = new Size(78, 23);
            label5.TabIndex = 22;
            label5.Text = "Pay Limit";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(253, 231);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(80, 30);
            textBox3.TabIndex = 20;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(338, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(135, 30);
            textBox2.TabIndex = 19;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(281, 162);
            label4.Name = "label4";
            label4.Size = new Size(42, 23);
            label4.TabIndex = 18;
            label4.Text = "Title";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(264, 122);
            label3.Name = "label3";
            label3.Size = new Size(58, 23);
            label3.TabIndex = 17;
            label3.Text = "Job ID";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(220, 88);
            label2.Name = "label2";
            label2.Size = new Size(105, 23);
            label2.TabIndex = 16;
            label2.Text = "Company ID";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(303, 32);
            label1.Name = "label1";
            label1.Size = new Size(97, 26);
            label1.TabIndex = 15;
            label1.Text = "Job Module";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(338, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 30);
            textBox1.TabIndex = 14;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(303, 351);
            button1.Name = "button1";
            button1.Size = new Size(101, 31);
            button1.TabIndex = 13;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Location = new Point(338, 159);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(135, 30);
            textBox4.TabIndex = 26;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.Location = new Point(389, 228);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(84, 30);
            textBox5.TabIndex = 27;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(220, 231);
            label7.Name = "label7";
            label7.Size = new Size(27, 23);
            label7.TabIndex = 28;
            label7.Text = "Rs";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(338, 231);
            label8.Name = "label8";
            label8.Size = new Size(48, 23);
            label8.TabIndex = 29;
            label8.Text = "to Rs";
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.None;
            textBox6.Location = new Point(338, 288);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(135, 29);
            textBox6.TabIndex = 30;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(539, 27);
            button2.Name = "button2";
            button2.Size = new Size(154, 31);
            button2.TabIndex = 31;
            button2.Text = "Company Module";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(720, 414);
            Controls.Add(button2);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "Form4";
            Text = "Job Module";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label7;
        private Label label8;
        private TextBox textBox6;
        private Button button2;
    }
}