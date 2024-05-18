namespace _17_ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLongitudOrdenadas_Click(object sender, EventArgs e)
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

            palabrasFiltradas.Sort();

            txtResultado.Text = string.Join(", ", palabrasFiltradas);
        }
        private List<string> FiltrarPorLongitud(List<string> palabras, int longitud)
        {
            // Filtrar las palabras por longitud
            return palabras.Where(p => p.Length == longitud).ToList();
        }

    }
}
