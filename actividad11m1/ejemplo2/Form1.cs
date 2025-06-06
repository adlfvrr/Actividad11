namespace ejemplo2
{
    public partial class Form1 : Form
    {
        static double ac = 0;
        static int cont = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void lbValor_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ac += Convert.ToDouble(tbValor.Text);
            cont++;
            tbValor.Clear();
        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
            double prom = ac / cont;
            lbPromedio.Text = $"{prom}";
            tbPromedio.Text = $@"Promedio:
                                {prom}";
        }

        private void tbValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
