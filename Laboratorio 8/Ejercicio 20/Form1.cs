namespace _20_ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnPalindromosLongitudOrdenadas_Click(object sender, EventArgs e)
        {
            string entradaPalabras = txtPalabras.Text;
            string entradaLongitud = txtLongitud.Text;

            if (!int.TryParse(entradaLongitud, out int longitud))
            {
                MessageBox.Show("Por favor, ingrese una longitud válida.");
                return;
            }

            List<string> palabras = entradaPalabras.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                                    .Select(p => p.Trim())
                                                    .ToList();

            List<string> palabrasFiltradas = FiltrarPorLongitud(palabras, longitud);

            List<string> palindromos = FiltrarPalindromos(palabrasFiltradas);

            // Ordenar los palíndromos de menor a mayor longitud
            palindromos.Sort();

            // Mostrar el resultado
            txtResultado.Text = string.Join(", ", palindromos);
        }
        private List<string> FiltrarPorLongitud(List<string> palabras, int longitud)
        {
            return palabras.Where(p => p.Length == longitud).ToList();
        }

        private List<string> FiltrarPalindromos(List<string> palabras)
        {
            return palabras.Where(p => EsPalindromo(p)).ToList();
        }

        private bool EsPalindromo(string palabra)
        {
            // Comparar la palabra con su versión invertida
            string palabraInvertida = new string(palabra.Reverse().ToArray());
            return palabra.Equals(palabraInvertida, StringComparison.OrdinalIgnoreCase);
        }
    }
}
