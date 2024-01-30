namespace Calorie_Counter
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // going to take in 2 things, the route
            Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
        }
    }
}
