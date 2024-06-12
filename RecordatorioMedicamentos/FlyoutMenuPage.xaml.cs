using RecordatorioMedicamentos.Class;

namespace RecordatorioMedicamentos;

public partial class FlyoutMenuPage : ContentPage
{
	public FlyoutMenuPage()
	{
		InitializeComponent();
	}
    private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var item = e.SelectedItem as FlyoutMenuItem;
        if (item != null)
        {
            ((FlyoutPage)Application.Current.MainPage).Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
            ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
        }
    }
}