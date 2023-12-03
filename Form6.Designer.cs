namespace WWS_Trimmer
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            exitButton = new Button();
            panel1 = new Panel();
            checkBoxRotateRv = new CheckBox();
            checkBoxRotate = new CheckBox();
            button3 = new Button();
            label5 = new Label();
            button1 = new Button();
            pictureBoxS = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxS).BeginInit();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.WhiteSmoke;
            exitButton.BackgroundImageLayout = ImageLayout.Zoom;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.ForeColor = Color.WhiteSmoke;
            exitButton.Image = (Image)resources.GetObject("exitButton.Image");
            exitButton.Location = new Point(700, -3);
            exitButton.Name = "exitButton";
            exitButton.RightToLeft = RightToLeft.No;
            exitButton.Size = new Size(37, 39);
            exitButton.TabIndex = 25;
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(746, 39);
            panel1.TabIndex = 26;
            // 
            // checkBoxRotateRv
            // 
            checkBoxRotateRv.AutoSize = true;
            checkBoxRotateRv.Location = new Point(15, 167);
            checkBoxRotateRv.Name = "checkBoxRotateRv";
            checkBoxRotateRv.Size = new Size(135, 24);
            checkBoxRotateRv.TabIndex = 29;
            checkBoxRotateRv.Text = "Obrót o 90% <-";
            checkBoxRotateRv.UseVisualStyleBackColor = true;
            checkBoxRotateRv.CheckedChanged += checkBoxRotateRv_CheckedChanged;
            // 
            // checkBoxRotate
            // 
            checkBoxRotate.AutoSize = true;
            checkBoxRotate.Location = new Point(197, 167);
            checkBoxRotate.Name = "checkBoxRotate";
            checkBoxRotate.Size = new Size(135, 24);
            checkBoxRotate.TabIndex = 28;
            checkBoxRotate.Text = "Obrót o 90% ->";
            checkBoxRotate.CheckedChanged += checkBoxRotate_CheckedChanged;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button3.Location = new Point(26, 200);
            button3.Name = "button3";
            button3.Size = new Size(285, 52);
            button3.TabIndex = 27;
            button3.Text = "Obróć";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.Location = new Point(12, 54);
            label5.Name = "label5";
            label5.Size = new Size(383, 20);
            label5.TabIndex = 31;
            label5.Text = "Wybrany PDF: Brak - skorzystaj z poniższego przycisku";
            // 
            // button1
            // 
            button1.AllowDrop = true;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.Location = new Point(12, 77);
            button1.Name = "button1";
            button1.Size = new Size(150, 29);
            button1.TabIndex = 30;
            button1.Text = "Wybierz PDF";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBoxS
            // 
            pictureBoxS.Image = (Image)resources.GetObject("pictureBoxS.Image");
            pictureBoxS.Location = new Point(448, 54);
            pictureBoxS.Name = "pictureBoxS";
            pictureBoxS.Size = new Size(272, 242);
            pictureBoxS.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxS.TabIndex = 32;
            pictureBoxS.TabStop = false;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(740, 310);
            Controls.Add(pictureBoxS);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(checkBoxRotateRv);
            Controls.Add(checkBoxRotate);
            Controls.Add(button3);
            Controls.Add(exitButton);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form6";
            Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)pictureBoxS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitButton;
        private Panel panel1;
        private CheckBox checkBoxRotateRv;
        private CheckBox checkBoxRotate;
        private Button button3;
        private Label label5;
        private Button button1;
        private PictureBox pictureBoxS;
    }
}