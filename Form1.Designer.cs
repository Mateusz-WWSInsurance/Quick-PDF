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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AllowDrop = true;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.Location = new Point(149, 66);
            button1.Name = "button1";
            button1.Size = new Size(150, 29);
            button1.TabIndex = 0;
            button1.Text = "Wybierz PDF";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(165, 178);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(36, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(237, 178);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(36, 27);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(165, 155);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 4;
            label1.Text = "Od";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(244, 155);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 5;
            label2.Text = "Do";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 182);
            label3.Name = "label3";
            label3.Size = new Size(15, 20);
            label3.TabIndex = 6;
            label3.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.Location = new Point(127, 122);
            label4.Name = "label4";
            label4.Size = new Size(190, 20);
            label4.TabIndex = 7;
            label4.Text = "Zakres stron do przycięcia";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button3.Location = new Point(92, 292);
            button3.Name = "button3";
            button3.Size = new Size(259, 52);
            button3.TabIndex = 9;
            button3.Text = "Wykonaj";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.Location = new Point(12, 39);
            label5.Name = "label5";
            label5.Size = new Size(383, 20);
            label5.TabIndex = 10;
            label5.Text = "Wybrany PDF: Brak - skorzystaj z poniższego przycisku";
            // 
            // exitButton
            // 
            exitButton.BackgroundImageLayout = ImageLayout.Zoom;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.ForeColor = SystemColors.ControlLightLight;
            exitButton.Image = (Image)resources.GetObject("exitButton.Image");
            exitButton.Location = new Point(731, -1);
            exitButton.Name = "exitButton";
            exitButton.RightToLeft = RightToLeft.No;
            exitButton.Size = new Size(37, 39);
            exitButton.TabIndex = 11;
            exitButton.UseVisualStyleBackColor = true;
            // 
            // minimizeButton
            // 
            minimizeButton.BackgroundImageLayout = ImageLayout.Zoom;
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.ForeColor = SystemColors.ControlLightLight;
            minimizeButton.Image = (Image)resources.GetObject("minimizeButton.Image");
            minimizeButton.ImageAlign = ContentAlignment.MiddleLeft;
            minimizeButton.Location = new Point(699, -1);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.RightToLeft = RightToLeft.No;
            minimizeButton.Size = new Size(31, 39);
            minimizeButton.TabIndex = 12;
            minimizeButton.UseVisualStyleBackColor = true;
            // 
            // checkBoxRotate
            // 
            checkBoxRotate.AutoSize = true;
            checkBoxRotate.Location = new Point(248, 252);
            checkBoxRotate.Name = "checkBoxRotate";
            checkBoxRotate.Size = new Size(135, 24);
            checkBoxRotate.TabIndex = 13;
            checkBoxRotate.Text = "Obrót o 90% ->";
            // 
            // checkBoxRotateRv
            // 
            checkBoxRotateRv.AutoSize = true;
            checkBoxRotateRv.Location = new Point(66, 252);
            checkBoxRotateRv.Name = "checkBoxRotateRv";
            checkBoxRotateRv.Size = new Size(135, 24);
            checkBoxRotateRv.TabIndex = 14;
            checkBoxRotateRv.Text = "Obrót o 90% <-";
            checkBoxRotateRv.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.AllowDrop = true;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button2.Location = new Point(12, 381);
            button2.Name = "button2";
            button2.Size = new Size(150, 29);
            button2.TabIndex = 15;
            button2.Text = "O programie";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.AllowDrop = true;
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button4.Location = new Point(282, 381);
            button4.Name = "button4";
            button4.Size = new Size(150, 29);
            button4.TabIndex = 16;
            button4.Text = "Zgłoś błąd";
            button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(458, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(771, 422);
            Controls.Add(pictureBox1);
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
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WWS Trimmer";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}
