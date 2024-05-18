namespace _19_ejerciccio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrdenadosNoDuplicados_Click(object sender, EventArgs e)
        {
            string entradaNumeros = txtNumeros.Text;

            List<int> numeros = entradaNumeros.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                              .Select(n => int.Parse(n.Trim()))
                                              .ToList();

            List<int> numerosOrdenadosNoDuplicados = OrdenarNoDuplicados(numeros);

            txtResultado.Text = string.Join(", ", numerosOrdenadosNoDuplicados);
        }
        private List<int> OrdenarNoDuplicados(List<int> numeros)
        {
            // Utilizar LINQ para ordenar los números de menor a mayor y eliminar duplicados
            return numeros.OrderBy(n => n).Distinct().ToList();
        }
    }
}
