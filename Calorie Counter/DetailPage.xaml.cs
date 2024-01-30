using Calorie_Counter.Properties.ViewModel;

namespace Calorie_Counter;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}