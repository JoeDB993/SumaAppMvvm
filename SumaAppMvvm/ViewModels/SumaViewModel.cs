using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SumaAppMvvm.ViewModels
{
    public partial class SumaViewModel : ObservableObject
    {
        [ObservableProperty]
        private double a;

        [ObservableProperty]
        private double b;
        

        private double result;

        private void Alerta(string Título, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Título, Mensaje, "Aceptar"));
        }
        [RelayCommand]
        private void calcular()
        {
            if (A == 0 || B == 0)
            {
                Alerta("Advertencia", "Valor de A o B no puede ser cero.");
            }
            else 
            {
                result = a + b;

            }
        }
    }
}


