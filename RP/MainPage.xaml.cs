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
           
            int monto = 0;
            if (radioButton3RP.IsChecked)
                monto = 3;
            else if (radioButton5RP.IsChecked)
                monto = 5;
            else if (radioButton10RP.IsChecked)
                monto = 10;

           
            bool confirmacion = await DisplayAlert("Confirmación", $"¿Desea recargar ${monto} al número {txtPhoneNumber.Text} con el operador {pickerOperator.SelectedItem}?", "Sí", "No");

            
            if (confirmacion)
            {
                await RealizarRecarga();
            }
        }

       
        private async Task RealizarRecarga()
        {
            
            await Task.Delay(2000); 
            await DisplayAlert("Recarga Exitosa", "La recarga se ha realizado exitosamente.", "OK");
        }
    }
}