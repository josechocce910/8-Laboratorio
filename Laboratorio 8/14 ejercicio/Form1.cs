namespace _14_ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumerosNoDuplicados_Click(object sender, EventArgs e)
        {
            string entradaNumeros = txtNumeros.Text;

            List<int> numeros = entradaNumeros.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                              .Select(n => int.Parse(n.Trim()))
                                              .ToList();

            HashSet<int> numerosNoDuplicados = EncontrarNumerosNoDuplicados(numeros);

            txtResultado.Text = string.Join(", ", numerosNoDuplicados);
        }
        private HashSet<int> EncontrarNumerosNoDuplicados(List<int> numeros)
        {
            // Utilizar LINQ para encontrar los números no duplicados
            return new HashSet<int>(numeros.GroupBy(x => x)
                                           .Where(g => g.Count() == 1)
                                           .Select(g => g.Key));
        }
    }
}
