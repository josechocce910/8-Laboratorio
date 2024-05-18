namespace _16_ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPalindromosOrdenados_Click(object sender, EventArgs e)
        {
            string entradaPalabras = txtPalabras.Text;

            List<string> palabras = entradaPalabras.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                                  .Select(p => p.Trim())
                                                  .ToList();

            List<string> palindromosOrdenados = EncontrarPalindromosOrdenados(palabras);

            txtResultado.Text = string.Join(", ", palindromosOrdenados);
        }
        private List<string> EncontrarPalindromosOrdenados(List<string> palabras)
        {
            // Filtrar las palabras que son palíndromos
            List<string> palindromos = palabras.Where(p => EsPalindromo(p)).ToList();

            // Ordenar los palíndromos de menor a mayor
            palindromos.Sort();

            return palindromos;
        }

        private bool EsPalindromo(string palabra)
        {
            string palabraInvertida = new string(palabra.Reverse().ToArray());
            return palabra.Equals(palabraInvertida, StringComparison.OrdinalIgnoreCase);
        }
    }
}
