namespace Laboratorio_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarPrimos_Click(object sender, EventArgs e)
        {
            string entrada = txtNumeros.Text;
            List<int> numeros = ObtenerNumerosDesdeCadena(entrada);
            List<int> numerosPrimos = ObtenerNumerosPrimos(numeros);
            txtResultado.Text = string.Join(", ", numerosPrimos);
        }

        private List<int> ObtenerNumerosDesdeCadena(string entrada)
        {
            var numeros = entrada.Split(',')
                                 .Select(n =>
                                 {
                                     if (int.TryParse(n.Trim(), out int num))
                                         return num;
                                     else
                                         return (int?)null;
                                 })
                                 .Where(n => n.HasValue)
                                 .Select(n => n.Value)
                                 .ToList();
            return numeros;
        }

        private List<int> ObtenerNumerosPrimos(List<int> numeros)
        {
            return numeros.Where(EsPrimo).ToList();
        }

        private bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtNumeros_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
