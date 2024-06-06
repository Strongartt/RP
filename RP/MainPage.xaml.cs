namespace RP
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Recargar_Clicked(object sender, EventArgs e)
        {
            // Obtener el monto seleccionado
            int monto = 0;
            if (radioButton3RP.IsChecked)
                monto = 3;
            else if (radioButton5RP.IsChecked)
                monto = 5;
            else if (radioButton10RP.IsChecked)
                monto = 10;

            // Confirmación de recarga
            bool confirmacion = await DisplayAlert("Confirmación", $"¿Desea recargar ${monto} al número {txtPhoneNumber.Text} con el operador {pickerOperator.SelectedItem}?", "Sí", "No");

            // Realizar la recarga si el usuario confirma
            if (confirmacion)
            {
                await RealizarRecarga();
            }
        }

        // Método asincrónico para realizar la recarga
        private async Task RealizarRecarga()
        {
            // Simular proceso de recarga
            await Task.Delay(2000); // Simulación de 2 segundos
            await DisplayAlert("Recarga Exitosa", "La recarga se ha realizado exitosamente.", "OK");
        }
    }
}