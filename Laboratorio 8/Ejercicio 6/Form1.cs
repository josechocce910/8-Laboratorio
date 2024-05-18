namespace _6_ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncontrarUnicos_Click(object sender, EventArgs e)
        {
            // Obtener las entradas de los TextBox
            string entrada1 = txtNumeros1.Text;
            string entrada2 = txtNumeros2.Text;

            // Convertir las entradas a listas de enteros
            List<int> numeros1 = ConvertirCadenaALista(entrada1);
            List<int> numeros2 = ConvertirCadenaALista(entrada2);

            // Encontrar los números únicos en el segundo conjunto
            List<int> numerosUnicos = EncontrarNumerosUnicos(numeros1, numeros2);

            // Mostrar el resultado
            txtResultado.Text = string.Join(", ", numerosUnicos);
        }
        private List<int> ConvertirCadenaALista(string cadena)
        {
            return cadena.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                         .Select(n => n.Trim())
                         .Where(n => int.TryParse(n, out _))
                         .Select(int.Parse)
                         .ToList();
        }

        private List<int> EncontrarNumerosUnicos(List<int> lista1, List<int> lista2)
        {
            HashSet<int> set1 = new HashSet<int>(lista1);
            return lista2.Where(n => !set1.Contains(n)).ToList();
        }
    }
}
