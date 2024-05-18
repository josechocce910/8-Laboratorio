namespace _4_ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEncontrarComunes_Click(object sender, EventArgs e)
        {
            // Obtener las entradas de los TextBox
            string entrada1 = txtNumeros1.Text;
            string entrada2 = txtNumeros2.Text;

            // Convertir las entradas a listas de enteros
            List<int> numeros1 = ConvertirCadenaALista(entrada1);
            List<int> numeros2 = ConvertirCadenaALista(entrada2);

            // Encontrar los números comunes
            List<int> numerosComunes = EncontrarNumerosComunes(numeros1, numeros2);

            // Mostrar el resultado
            txtResultado.Text = string.Join(", ", numerosComunes);
        }
        private List<int> ConvertirCadenaALista(string cadena)
        {
            return cadena.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                         .Select(n => n.Trim())
                         .Where(n => int.TryParse(n, out _))
                         .Select(int.Parse)
                         .ToList();
        }

        private List<int> EncontrarNumerosComunes(List<int> lista1, List<int> lista2)
        {
            HashSet<int> set = new HashSet<int>(lista1);
            return lista2.Where(n => set.Contains(n)).ToList();
        }
    }
}
