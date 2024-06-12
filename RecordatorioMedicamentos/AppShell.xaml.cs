namespace RecordatorioMedicamentos
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
            Routing.RegisterRoute(nameof(RegisterMedication), typeof(RegisterMedication));
            Routing.RegisterRoute(nameof(RegisterParentFamily), typeof(RegisterParentFamily));
            Routing.RegisterRoute(nameof(SearchMedicationDetail), typeof(SearchMedicationDetail));
            Routing.RegisterRoute(nameof(SearchINVIMARegister), typeof(SearchINVIMARegister));
            Routing.RegisterRoute(nameof(AppInformation), typeof(AppInformation));
            Routing.RegisterRoute(nameof(LogOut), typeof(LogOut));
        }
    }
}
