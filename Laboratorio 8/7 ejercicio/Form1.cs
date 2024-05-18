namespace _7_ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncontrarAnagramas_Click(object sender, EventArgs e)
        {
            // Obtener la entrada del TextBox
            string entrada = txtPalabras.Text;

            // Convertir la entrada a una lista de palabras
            List<string> palabras = entrada.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                           .Select(p => p.Trim())
                                           .ToList();

            // Encontrar los anagramas
            List<string> anagramas = EncontrarAnagramas(palabras);

            // Mostrar el resultado
            txtResultado.Text = string.Join(", ", anagramas);
        }
        private List<string> EncontrarAnagramas(List<string> palabras)
        {
            var dict = new Dictionary<string, List<string>>();

            foreach (var palabra in palabras)
            {
                var clave = new string(palabra.OrderBy(c => c).ToArray());
                if (dict.ContainsKey(clave))
                {
                    dict[clave].Add(palabra);
                }
                else
                {
                    dict[clave] = new List<string> { palabra };
                }
            }

            // Seleccionar solo los grupos con más de una palabra
            var anagramas = dict.Values.Where(grupo => grupo.Count > 1)
                                       .SelectMany(grupo => grupo)
                                       .ToList();

            return anagramas;
        }
    }
}