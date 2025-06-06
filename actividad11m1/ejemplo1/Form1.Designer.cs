namespace ejemplo1
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
            hola_mundo = new Button();
            SuspendLayout();
            // 
            // hola_mundo
            // 
            hola_mundo.Location = new Point(135, 47);
            hola_mundo.Name = "hola_mundo";
            hola_mundo.Size = new Size(266, 117);
            hola_mundo.TabIndex = 0;
            hola_mundo.Text = "Mostrar";
            hola_mundo.UseVisualStyleBackColor = true;
            hola_mundo.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 228);
            Controls.Add(hola_mundo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button hola_mundo;
    }
}
