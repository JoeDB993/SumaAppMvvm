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

        [ObservableProperty]
        private double result;

        private void Alerta(string titulo, string mensaje)
        {
            App.Current!.MainPage!.DisplayAlert(titulo, mensaje, "Aceptar");
        }

        [RelayCommand]
        private void Calcular()
        {
            if (A == 0 || B == 0)
            {
                Alerta("Advertencia", "Valor de A o B no puede ser cero.");
            }
            else
            {
                Result = A + B;
            }
        }

        [RelayCommand]
        private void Limpiar()
        {
            A = 0;
            B = 0;
            Result = 0;
        }
    }
}
