namespace _10_ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLetraDeterminada_Click(object sender, EventArgs e)
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

            HashSet<string> palabrasConLetra = FiltrarPorLetra(palabras, letra);

            txtResultado.Text = string.Join(", ", palabrasConLetra);
        }
        private HashSet<string> FiltrarPorLetra(List<string> palabras, char letra)
        {
            HashSet<string> palabrasConLetra = new HashSet<string>();

            foreach (string palabra in palabras)
            {
                if (palabra.Contains(letra))
                {
                    palabrasConLetra.Add(palabra);
                }
            }

            return palabrasConLetra;
        }
    }
}
