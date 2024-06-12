using Microsoft.Extensions.DependencyInjection;
using RecordatorioMedicamentos.Data;

namespace RecordatorioMedicamentos
{
    public partial class App : Application
    {
        static Database database;

        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "GestionMedicamentos.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            
            //Shell.Current.GoToAsync("//LoginPage");
            
            //MainPage = new FlyoutPage
            //{
            //    Flyout = new FlyoutMenuPage(),
            //    Detail = new NavigationPage(new LoginPage())
            //};
            //var sessionService = serviceProvider.GetRequiredService<SessionService>();
            var loginPage = new LoginPage();

            MainPage = new NavigationPage(loginPage); // Establecer LoginPage como la página de inicio sin menú
        }
    }
}
