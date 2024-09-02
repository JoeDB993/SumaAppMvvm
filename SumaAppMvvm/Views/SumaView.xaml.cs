using SumaAppMvvm.ViewModels;

namespace SumaAppMvvm.Views;

public partial class SumaView : ContentPage
{
	private SumaViewModel ViewModel;
	public SumaView()
	{
        InitializeComponent();
		ViewModel = new SumaViewModel();
		BindingContext = ViewModel;
	}
}