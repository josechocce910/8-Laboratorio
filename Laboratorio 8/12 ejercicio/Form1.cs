namespace _12_ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMayorAMenor_Click(object sender, EventArgs e)
        {
            string entradaNumeros = txtNumeros.Text;

            List<int> numeros = entradaNumeros.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                              .Select(n => int.Parse(n.Trim()))
                                              .ToList();

            List<int> numerosOrdenados = OrdenarDeMayorAMenor(numeros);

            txtResultado.Text = string.Join(", ", numerosOrdenados);
        }
        private List<int> OrdenarDeMayorAMenor(List<int> numeros)
        {
            return numeros.OrderByDescending(n => n).ToList();
        }
    }
}
