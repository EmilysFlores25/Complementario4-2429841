namespace Complementario42429841
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (double.TryParse(entry1.Text, out double a))
            {
                double cuadrado = a * a;
                double cubo = cuadrado * a;

                entry2.Text = $"Cuadrado: {cuadrado}, Cubo: {cubo}";
            }
            else
            {
                entry1.Text = "Ingresa un número válido.";
            }
        }
    }

}
