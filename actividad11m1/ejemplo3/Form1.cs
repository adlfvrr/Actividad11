namespace ejemplo3
{
    public partial class Form1 : Form
    {
        double[] prom = new double[20];
        double promedio;
        double ac = 0;
        int cont = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            prom[cont] = Convert.ToDouble(tbValor.Text);
            cont++;
            tbValor.Clear();
        }

        private void tbValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPromedio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < prom.Length; i++)
            {
                ac += prom[i];
            }
            promedio = ac / cont;
            lbPromedio.Text = $"{promedio:f2}";
            tbPromedio.Text = $@"Promedio:
                            {promedio:f2}";
        }
    }
}
