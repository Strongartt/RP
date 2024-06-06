using Microsoft.Maui;
using Microsoft.Maui.Controls;
using System;
using System.IO;
using System.Threading.Tasks;

namespace RP
{
    public partial class MainPage : ContentPage
    {
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

            // Confirmación de recarga
            bool confirmacion = await DisplayAlert("Confirmación", $"¿Desea recargar ${monto} al número {txtPhoneNumber.Text} con el operador {pickerOperator.SelectedItem}?", "Sí", "No");

           
            if (confirmacion)
            {
                await RealizarRecarga(monto);
            }
        }

        
        private async Task RealizarRecarga(int monto)
        {
           
            await Task.Delay(2000); 

          
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string fileName = $"{txtPhoneNumber.Text}.txt";
            string filePath = Path.Combine(desktopPath, fileName);

            string textoArchivo = $"Se hizo una recarga de ${monto} dólares en la siguiente fecha: {DateTime.Now}";

            File.WriteAllText(filePath, textoArchivo);

          
            await DisplayAlert("Recarga Exitosa", "La recarga se ha realizado exitosamente.", "OK");
        }
    }
}
