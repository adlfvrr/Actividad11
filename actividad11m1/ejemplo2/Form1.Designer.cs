namespace ejemplo2
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
            btnRegistrar = new Button();
            btnCalcularPromedio = new Button();
            tbValor = new TextBox();
            tbPromedio = new TextBox();
            lbValor = new Label();
            lbPromedio = new Label();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(544, 79);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(121, 34);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCalcularPromedio
            // 
            btnCalcularPromedio.Location = new Point(531, 174);
            btnCalcularPromedio.Name = "btnCalcularPromedio";
            btnCalcularPromedio.Size = new Size(134, 52);
            btnCalcularPromedio.TabIndex = 1;
            btnCalcularPromedio.Text = "Calcular promedio";
            btnCalcularPromedio.UseVisualStyleBackColor = true;
            btnCalcularPromedio.Click += btnCalcularPromedio_Click;
            // 
            // tbValor
            // 
            tbValor.Location = new Point(277, 79);
            tbValor.Multiline = true;
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(207, 34);
            tbValor.TabIndex = 2;
            // 
            // tbPromedio
            // 
            tbPromedio.Location = new Point(320, 232);
            tbPromedio.Multiline = true;
            tbPromedio.Name = "tbPromedio";
            tbPromedio.Size = new Size(368, 100);
            tbPromedio.TabIndex = 3;
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Location = new Point(219, 89);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(33, 15);
            lbValor.TabIndex = 4;
            lbValor.Text = "Valor";
            lbValor.Click += lbValor_Click;
            // 
            // lbPromedio
            // 
            lbPromedio.AutoSize = true;
            lbPromedio.Location = new Point(396, 206);
            lbPromedio.Name = "lbPromedio";
            lbPromedio.Size = new Size(62, 15);
            lbPromedio.TabIndex = 5;
            lbPromedio.Text = "Promedio:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 395);
            Controls.Add(lbPromedio);
            Controls.Add(lbValor);
            Controls.Add(tbPromedio);
            Controls.Add(tbValor);
            Controls.Add(btnCalcularPromedio);
            Controls.Add(btnRegistrar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Button btnCalcularPromedio;
        private TextBox tbValor;
        private TextBox tbPromedio;
        private Label lbValor;
        private Label lbPromedio;
    }
}
