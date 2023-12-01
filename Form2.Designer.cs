namespace WWS_Trimmer
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            minimizeButton = new Button();
            exitButton = new Button();
            FirstPDF = new Button();
            SecondPDF = new Button();
            button1 = new Button();
            labelFirstPdf = new Label();
            labelSecondPdf = new Label();
            SuspendLayout();
            // 
            // minimizeButton
            // 
            minimizeButton.BackgroundImageLayout = ImageLayout.Zoom;
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.ForeColor = SystemColors.ControlLightLight;
            minimizeButton.Image = (Image)resources.GetObject("minimizeButton.Image");
            minimizeButton.ImageAlign = ContentAlignment.MiddleLeft;
            minimizeButton.Location = new Point(730, 1);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.RightToLeft = RightToLeft.No;
            minimizeButton.Size = new Size(31, 39);
            minimizeButton.TabIndex = 14;
            minimizeButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.BackgroundImageLayout = ImageLayout.Zoom;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.ForeColor = SystemColors.ControlLightLight;
            exitButton.Image = (Image)resources.GetObject("exitButton.Image");
            exitButton.Location = new Point(762, 1);
            exitButton.Name = "exitButton";
            exitButton.RightToLeft = RightToLeft.No;
            exitButton.Size = new Size(37, 39);
            exitButton.TabIndex = 13;
            exitButton.UseVisualStyleBackColor = true;
            // 
            // FirstPDF
            // 
            FirstPDF.AllowDrop = true;
            FirstPDF.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            FirstPDF.Location = new Point(12, 72);
            FirstPDF.Name = "FirstPDF";
            FirstPDF.Size = new Size(150, 29);
            FirstPDF.TabIndex = 15;
            FirstPDF.Text = "Wybierz 1 PDF";
            FirstPDF.UseVisualStyleBackColor = true;
            // 
            // SecondPDF
            // 
            SecondPDF.AllowDrop = true;
            SecondPDF.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            SecondPDF.Location = new Point(12, 173);
            SecondPDF.Name = "SecondPDF";
            SecondPDF.Size = new Size(150, 29);
            SecondPDF.TabIndex = 16;
            SecondPDF.Text = "Wybierz 2 PDF";
            SecondPDF.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.AllowDrop = true;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.Location = new Point(12, 258);
            button1.Name = "button1";
            button1.Size = new Size(150, 29);
            button1.TabIndex = 17;
            button1.Text = "Wykonaj";
            button1.UseVisualStyleBackColor = true;
            // 
            // labelFirstPdf
            // 
            labelFirstPdf.AutoSize = true;
            labelFirstPdf.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelFirstPdf.Location = new Point(12, 49);
            labelFirstPdf.Name = "labelFirstPdf";
            labelFirstPdf.Size = new Size(383, 20);
            labelFirstPdf.TabIndex = 18;
            labelFirstPdf.Text = "Wybrany PDF: Brak - skorzystaj z poniższego przycisku";
            // 
            // labelSecondPdf
            // 
            labelSecondPdf.AutoSize = true;
            labelSecondPdf.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelSecondPdf.Location = new Point(12, 150);
            labelSecondPdf.Name = "labelSecondPdf";
            labelSecondPdf.Size = new Size(383, 20);
            labelSecondPdf.TabIndex = 19;
            labelSecondPdf.Text = "Wybrany PDF: Brak - skorzystaj z poniższego przycisku";
            // 
            // Form2
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(labelSecondPdf);
            Controls.Add(labelFirstPdf);
            Controls.Add(button1);
            Controls.Add(SecondPDF);
            Controls.Add(FirstPDF);
            Controls.Add(minimizeButton);
            Controls.Add(exitButton);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button minimizeButton;
        private Button exitButton;
        private Button FirstPDF;
        private Button SecondPDF;
        private Button button1;
        private Label labelFirstPdf;
        private Label labelSecondPdf;
    }
}