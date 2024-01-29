using Calorie_Counter.Properties.ViewModel;

namespace Calorie_Counter
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainViewModel vm)//passing in a vm or view model
        {
            InitializeComponent();
            /*BindingContext = new MainViewModel();
             * could do it this way^, but we can also 
             * use the built in dependency injection system
             * to cascade these down. This will be beneficial when 
             * adding additional dependencies into the main view model
             */
            BindingContext = vm;
        }
    }
}