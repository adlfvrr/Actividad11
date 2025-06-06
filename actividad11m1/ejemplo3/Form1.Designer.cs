namespace ejemplo3
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
            lbValor = new Label();
            tbValor = new TextBox();
            btnRegistrar = new Button();
            lbPromedio = new Label();
            tbPromedio = new TextBox();
            btnCalcularPromedio = new Button();
            SuspendLayout();
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Font = new Font("Segoe UI", 20F);
            lbValor.Location = new Point(277, 123);
            lbValor.Margin = new Padding(4, 0, 4, 0);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(78, 37);
            lbValor.TabIndex = 0;
            lbValor.Text = "Valor";
            // 
            // tbValor
            // 
            tbValor.Location = new Point(399, 123);
            tbValor.Margin = new Padding(4);
            tbValor.Multiline = true;
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(201, 36);
            tbValor.TabIndex = 1;
            tbValor.TextChanged += tbValor_TextChanged;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(690, 109);
            btnRegistrar.Margin = new Padding(4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(183, 57);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lbPromedio
            // 
            lbPromedio.AutoSize = true;
            lbPromedio.Font = new Font("Segoe UI", 20F);
            lbPromedio.Location = new Point(447, 221);
            lbPromedio.Name = "lbPromedio";
            lbPromedio.Size = new Size(139, 37);
            lbPromedio.TabIndex = 3;
            lbPromedio.Text = "Promedio:";
            // 
            // tbPromedio
            // 
            tbPromedio.Location = new Point(357, 274);
            tbPromedio.Multiline = true;
            tbPromedio.Name = "tbPromedio";
            tbPromedio.Size = new Size(327, 133);
            tbPromedio.TabIndex = 4;
            tbPromedio.TextChanged += tbPromedio_TextChanged;
            // 
            // btnCalcularPromedio
            // 
            btnCalcularPromedio.Location = new Point(611, 221);
            btnCalcularPromedio.Name = "btnCalcularPromedio";
            btnCalcularPromedio.Size = new Size(192, 47);
            btnCalcularPromedio.TabIndex = 5;
            btnCalcularPromedio.Text = "Calcular promedio";
            btnCalcularPromedio.UseVisualStyleBackColor = true;
            btnCalcularPromedio.Click += btnCalcularPromedio_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 481);
            Controls.Add(btnCalcularPromedio);
            Controls.Add(tbPromedio);
            Controls.Add(lbPromedio);
            Controls.Add(btnRegistrar);
            Controls.Add(tbValor);
            Controls.Add(lbValor);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbValor;
        private TextBox tbValor;
        private Button btnRegistrar;
        private Label label1;
        private TextBox textBox1;
        private Label lbPromedio;
        private TextBox tbPromedio;
        private Button btnCalcularPromedio;
    }
}
