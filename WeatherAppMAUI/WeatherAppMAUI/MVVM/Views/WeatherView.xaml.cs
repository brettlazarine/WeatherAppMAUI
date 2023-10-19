using WeatherAppMAUI.MVVM.ViewModels;

namespace WeatherAppMAUI.MVVM.Views;

public partial class WeatherView : ContentPage
{
	public WeatherView()
	{
		InitializeComponent();

		BindingContext = new WeatherViewModel();
	}
}