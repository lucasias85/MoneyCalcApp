namespace MoneyCalcApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppCode.Pages.TaxasInfoPage();
            //MainPage = new AppShell();
        }
    }
}
