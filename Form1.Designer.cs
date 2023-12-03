namespace WWS_Trimmer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button3 = new Button();
            label5 = new Label();
            exitButton = new Button();
            minimizeButton = new Button();
            checkBoxRotate = new CheckBox();
            checkBoxRotateRv = new CheckBox();
            button2 = new Button();
            button4 = new Button();
            pictureBoxS = new PictureBox();
            button5 = new Button();
            button6 = new Button();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            button7 = new Button();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxS).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AllowDrop = true;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.Location = new Point(149, 77);
            button1.Name = "button1";
            button1.Size = new Size(150, 29);
            button1.TabIndex = 0;
            button1.Text = "Wybierz PDF";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(169, 189);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(36, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(241, 189);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(36, 27);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(169, 166);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 4;
            label1.Text = "Od";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(248, 166);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 5;
            label2.Text = "Do";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 193);
            label3.Name = "label3";
            label3.Size = new Size(15, 20);
            label3.TabIndex = 6;
            label3.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.Location = new Point(127, 133);
            label4.Name = "label4";
            label4.Size = new Size(190, 20);
            label4.TabIndex = 7;
            label4.Text = "Zakres stron do przycięcia";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button3.Location = new Point(77, 260);
            button3.Name = "button3";
            button3.Size = new Size(285, 52);
            button3.TabIndex = 9;
            button3.Text = "Przytnij / Obróć";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.Location = new Point(12, 50);
            label5.Name = "label5";
            label5.Size = new Size(383, 20);
            label5.TabIndex = 10;
            label5.Text = "Wybrany PDF: Brak - skorzystaj z poniższego przycisku";
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.WhiteSmoke;
            exitButton.BackgroundImageLayout = ImageLayout.Zoom;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.ForeColor = Color.WhiteSmoke;
            exitButton.Image = (Image)resources.GetObject("exitButton.Image");
            exitButton.Location = new Point(731, -2);
            exitButton.Name = "exitButton";
            exitButton.RightToLeft = RightToLeft.No;
            exitButton.Size = new Size(37, 35);
            exitButton.TabIndex = 11;
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // minimizeButton
            // 
            minimizeButton.BackColor = Color.WhiteSmoke;
            minimizeButton.BackgroundImageLayout = ImageLayout.None;
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.ForeColor = Color.WhiteSmoke;
            minimizeButton.Image = (Image)resources.GetObject("minimizeButton.Image");
            minimizeButton.Location = new Point(699, -2);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.RightToLeft = RightToLeft.No;
            minimizeButton.Size = new Size(31, 35);
            minimizeButton.TabIndex = 12;
            minimizeButton.UseVisualStyleBackColor = false;
            minimizeButton.Click += minimizeButton_Click;
            // 
            // checkBoxRotate
            // 
            checkBoxRotate.AutoSize = true;
            checkBoxRotate.Location = new Point(248, 227);
            checkBoxRotate.Name = "checkBoxRotate";
            checkBoxRotate.Size = new Size(135, 24);
            checkBoxRotate.TabIndex = 13;
            checkBoxRotate.Text = "Obrót o 90% ->";
            checkBoxRotate.CheckedChanged += checkBoxRotate_CheckedChanged;
            // 
            // checkBoxRotateRv
            // 
            checkBoxRotateRv.AutoSize = true;
            checkBoxRotateRv.Location = new Point(66, 227);
            checkBoxRotateRv.Name = "checkBoxRotateRv";
            checkBoxRotateRv.Size = new Size(135, 24);
            checkBoxRotateRv.TabIndex = 14;
            checkBoxRotateRv.Text = "Obrót o 90% <-";
            checkBoxRotateRv.UseVisualStyleBackColor = true;
            checkBoxRotateRv.CheckedChanged += checkBoxRotateRv_CheckedChanged;
            // 
            // button2
            // 
            button2.AllowDrop = true;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button2.Location = new Point(453, 484);
            button2.Name = "button2";
            button2.Size = new Size(150, 29);
            button2.TabIndex = 15;
            button2.Text = "O programie";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.AllowDrop = true;
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button4.Location = new Point(609, 484);
            button4.Name = "button4";
            button4.Size = new Size(150, 29);
            button4.TabIndex = 16;
            button4.Text = "Zgłoś błąd";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBoxS
            // 
            pictureBoxS.Image = (Image)resources.GetObject("pictureBoxS.Image");
            pictureBoxS.Location = new Point(458, 99);
            pictureBoxS.Name = "pictureBoxS";
            pictureBoxS.Size = new Size(272, 242);
            pictureBoxS.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxS.TabIndex = 17;
            pictureBoxS.TabStop = false;
            // 
            // button5
            // 
            button5.AllowDrop = true;
            button5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(77, 377);
            button5.Name = "button5";
            button5.Size = new Size(135, 131);
            button5.TabIndex = 18;
            button5.Text = "Scalanie PDF";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = true;
            button5.Click += Button5_Click;
            // 
            // button6
            // 
            button6.AllowDrop = true;
            button6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(228, 377);
            button6.Name = "button6";
            button6.Size = new Size(134, 131);
            button6.TabIndex = 19;
            button6.Text = "Kompresja PDF";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(488, 461);
            label6.Name = "label6";
            label6.Size = new Size(242, 20);
            label6.TabIndex = 20;
            label6.Text = "Quick PDF v. 1.2.1 |  WWS Insurance";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.Location = new Point(152, 354);
            label7.Name = "label7";
            label7.Size = new Size(147, 20);
            label7.TabIndex = 21;
            label7.Text = "Pozostałe narzędzia";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Location = new Point(-4, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(783, 39);
            panel1.TabIndex = 22;
            // 
            // button7
            // 
            button7.AllowDrop = true;
            button7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(77, 523);
            button7.Name = "button7";
            button7.Size = new Size(135, 131);
            button7.TabIndex = 23;
            button7.Text = "Wycinanie PDF";
            button7.TextAlign = ContentAlignment.BottomCenter;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.AllowDrop = true;
            button8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(228, 523);
            button8.Name = "button8";
            button8.Size = new Size(135, 131);
            button8.TabIndex = 24;
            button8.Text = "Obracanie PDF";
            button8.TextAlign = ContentAlignment.BottomCenter;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(771, 741);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(pictureBoxS);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(checkBoxRotateRv);
            Controls.Add(checkBoxRotate);
            Controls.Add(minimizeButton);
            Controls.Add(exitButton);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quick PDF";
            ((System.ComponentModel.ISupportInitialize)pictureBoxS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button3;
        private Label label5;
        private Button exitButton;
        private Button minimizeButton;
        private CheckBox checkBoxRotate;
        private CheckBox checkBoxRotateRv;
        private Button button2;
        private Button button4;
        private PictureBox pictureBoxS;
        private Button button5;
        private Button button6;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Button button7;
        private Button button8;
    }
}
