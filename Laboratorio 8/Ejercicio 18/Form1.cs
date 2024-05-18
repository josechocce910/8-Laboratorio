namespace _18_ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPalabrasConLetra_Click(object sender, EventArgs e)
        {
            string entradaPalabras = txtPalabras.Text;
            string entradaLetra = txtLetra.Text;

            if (string.IsNullOrWhiteSpace(entradaLetra) || entradaLetra.Length != 1)
            {
                MessageBox.Show("Por favor, ingrese una sola letra válida.");
                return;
            }

            char letra = entradaLetra[0];

            List<string> palabras = entradaPalabras.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                                    .Select(p => p.Trim())
                                                    .ToList();

            List<string> palabrasConLetra = FiltrarPorLetra(palabras, letra);

            palabrasConLetra.Sort((x, y) => y.Length.CompareTo(x.Length));

            // Mostrar el resultado
            txtResultado.Text = string.Join(", ", palabrasConLetra);
        }
        private List<string> FiltrarPorLetra(List<string> palabras, char letra)
        {
            // Filtrar las palabras que contienen la letra determinada
            return palabras.Where(p => p.Contains(letra)).ToList();
        }
    }
}
