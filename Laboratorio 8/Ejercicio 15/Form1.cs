namespace _15_ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumerosPrimos_Click(object sender, EventArgs e)
        {
            string entradaNumeros = txtNumeros.Text;

            List<int> numeros = entradaNumeros.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                              .Select(n => int.Parse(n.Trim()))
                                              .ToList();

            HashSet<int> numerosPrimos = EncontrarNumerosPrimos(numeros);

            txtResultado.Text = string.Join(", ", numerosPrimos);
        }
        private HashSet<int> EncontrarNumerosPrimos(List<int> numeros)
        {
            HashSet<int> primos = new HashSet<int>();

            foreach (int numero in numeros)
            {
                if (EsPrimo(numero))
                {
                    primos.Add(numero);
                }
            }

            return primos;
        }

        private bool EsPrimo(int numero)
        {
            if (numero <= 1)
                return false;
            if (numero == 2)
                return true;
            if (numero % 2 == 0)
                return false;

            for (int i = 3; i * i <= numero; i += 2)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }
    }
}
