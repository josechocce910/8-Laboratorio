namespace _2_pregunta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFiltrarPalabras_Click(object sender, EventArgs e)
        {
            string entradaPalabras = txtPalabras.Text;
            string letra = txtLetra.Text.Trim();

            if (letra.Length != 1)
            {
                MessageBox.Show("Por favor, ingrese una sola letra.");
                return;
            }

            List<string> palabras = ObtenerPalabrasDesdeCadena(entradaPalabras);
            List<string> palabrasFiltradas = FiltrarPalabrasPorLetra(palabras, letra[0]);
            txtResultado.Text = string.Join(", ", palabrasFiltradas);
        }
        private List<string> ObtenerPalabrasDesdeCadena(string entrada)
        {
            return entrada.Split(',').Select(p => p.Trim()).ToList();
        }

        private List<string> FiltrarPalabrasPorLetra(List<string> palabras, char letra)
        {
            return palabras.Where(p => p.StartsWith(letra.ToString(), StringComparison.OrdinalIgnoreCase)).ToList();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPalabras_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
