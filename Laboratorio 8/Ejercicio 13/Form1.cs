namespace _13_ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NumerosDuplicados_Click(object sender, EventArgs e)
        {
            string entradaNumeros = txtNumeros.Text;

            List<int> numeros = entradaNumeros.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                              .Select(n => int.Parse(n.Trim()))
                                              .ToList();

            HashSet<int> numerosDuplicados = EncontrarNumerosDuplicados(numeros);

            txtResultado.Text = string.Join(", ", numerosDuplicados);
        }
        private HashSet<int> EncontrarNumerosDuplicados(List<int> numeros)
        {
            // Utilizar LINQ para encontrar los números duplicados
            return new HashSet<int>(numeros.GroupBy(x => x)
                                           .Where(g => g.Count() > 1)
                                           .Select(g => g.Key));
        }
    }
}
