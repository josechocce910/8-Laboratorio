namespace _8_ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularPalindromos_Click(object sender, EventArgs e)
        {
            string entrada = txtPalabras.Text;

            List<string> palabras = entrada.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                           .Select(p => p.Trim())
                                           .ToList();

            HashSet<string> palindromos = CalcularPalindromos(palabras);

            txtResultado.Text = string.Join(", ", palindromos);
        }
        private HashSet<string> CalcularPalindromos(List<string> palabras)
        {
            HashSet<string> palindromos = new HashSet<string>();

            foreach (string palabra in palabras)
            {
                if (EsPalindromo(palabra))
                {
                    palindromos.Add(palabra);
                }
            }

            return palindromos;
        }

        private bool EsPalindromo(string palabra)
        {
            // Comparar la palabra con su versión invertida
            string palabraInvertida = new string(palabra.Reverse().ToArray());
            return palabra.Equals(palabraInvertida, StringComparison.OrdinalIgnoreCase);
        }
    }
}
