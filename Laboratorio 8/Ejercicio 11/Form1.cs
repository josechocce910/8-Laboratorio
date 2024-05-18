namespace _11_ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMenorAMayor_Click(object sender, EventArgs e)
        {
            string entradaNumeros = txtNumeros.Text;

            List<int> numeros = entradaNumeros.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                              .Select(n => int.Parse(n.Trim()))
                                              .ToList();

            List<int> numerosOrdenados = OrdenarDeMenorAMayor(numeros);

            txtResultado.Text = string.Join(", ", numerosOrdenados);
        }
        private List<int> OrdenarDeMenorAMayor(List<int> numeros)
        {
            return numeros.OrderBy(n => n).ToList();
        }
    }
}
