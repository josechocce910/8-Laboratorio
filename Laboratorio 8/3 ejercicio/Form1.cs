namespace _3_ejercicio
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
        private List<int> ObtenerNumerosDesdeCadena(string entrada)
        {
            // Convertir la cadena de números separados por comas en una lista de enteros
            var numeros = entrada.Split(',')
                                 .Select(n =>
                                 {
                                     if (int.TryParse(n.Trim(), out int num))
                                         return num;
                                     else
                                         return (int?)null;
                                 })
                                 .Where(n => n.HasValue)
                                 .Select(n => n.Value)
                                 .ToList();
            return numeros;
        }

        private List<int> FiltrarNumerosPorDivisor(List<int> numeros, int divisor)
        {
            // Filtrar los números que son divisibles por el divisor especificado
            return numeros.Where(n => n % divisor == 0).ToList();
        }

        private void btnFiltrarNumeros_Click(object sender, EventArgs e)
        {
            // Obtener la cadena de números ingresados
            string entradaNumeros = txtNumeros.Text;
            // Intentar parsear el divisor
            if (int.TryParse(txtDivisor.Text, out int divisor) && divisor != 0)
            {
                // Convertir la cadena de números en una lista de enteros
                List<int> numeros = ObtenerNumerosDesdeCadena(entradaNumeros);
                // Filtrar los números divisibles por el divisor
                List<int> numerosDivisibles = FiltrarNumerosPorDivisor(numeros, divisor);
                // Mostrar el resultado en el TextBox de resultados
                txtResultado.Text = string.Join(", ", numerosDivisibles);
            }
            else
            {
                // Mostrar un mensaje de error si el divisor no es válido
                MessageBox.Show("Por favor, ingrese un divisor válido (diferente de 0).");
            }
        }
    }
}
