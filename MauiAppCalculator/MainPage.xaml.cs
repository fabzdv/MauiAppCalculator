namespace MauiAppCalculator
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Soma(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txt_num1.Text);
            double n2 = Convert.ToDouble(txt_num2.Text);

            double soma = n1 + n2;

            string msg = $"A soma é igual a {soma} ";

            DisplayAlert("Resultado", msg, "Fechar");
        } // soma

        private void Sub(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txt_num1.Text);
            double n2 = Convert.ToDouble(txt_num2.Text);

            double soma = n1 - n2;

            string msg = $"A subtração é igual a {soma} ";

            DisplayAlert("Resultado", msg, "Fechar");
        } // subtração

        private void Multi(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txt_num1.Text);
            double n2 = Convert.ToDouble(txt_num2.Text);

            double soma = n1 * n2;

            string msg = $"A multiplicação é igual a {soma} ";

            DisplayAlert("Resultado", msg, "Fechar");
        } // multiplicação

        private void Div(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txt_num1.Text);
            double n2 = Convert.ToDouble(txt_num2.Text);

            double soma = n1 / n2;

            string msg = $"A divisão é igual a {soma} ";

            DisplayAlert("Resultado", msg, "Fechar");
        } // divisão
    }

}
