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
    private void OnEntryFocused(object sender, FocusEventArgs e)
    {
        if (sender is Entry entry)
        {
            if (string.IsNullOrEmpty(entry.Text) || entry.Text == "0")
            {
                entry.Text = string.Empty;
            }
        }
    }
}