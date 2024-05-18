namespace _9_ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFiltrarPorLongitud_Click(object sender, EventArgs e)
        {
            string entradaPalabras = txtPalabras.Text;
            string entradaLongitud = txtLongitud.Text;

            // Convertir la entrada de longitud a un número entero
            if (!int.TryParse(entradaLongitud, out int longitud))
            {
                MessageBox.Show("Por favor, ingrese una longitud válida.");
                return;
            }

            List<string> palabras = entradaPalabras.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                                    .Select(p => p.Trim())
                                                    .ToList();

            HashSet<string> palabrasFiltradas = FiltrarPorLongitud(palabras, longitud);

            txtResultado.Text = string.Join(", ", palabrasFiltradas);
        }
        private HashSet<string> FiltrarPorLongitud(List<string> palabras, int longitud)
        {
            HashSet<string> palabrasFiltradas = new HashSet<string>();

            foreach (string palabra in palabras)
            {
                if (palabra.Length == longitud)
                {
                    palabrasFiltradas.Add(palabra);
                }
            }

            return palabrasFiltradas;
        }
    }
}
