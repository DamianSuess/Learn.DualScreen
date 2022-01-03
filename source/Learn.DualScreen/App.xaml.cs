using Learn.DualScreen.ViewModels;
using Learn.DualScreen.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace Learn.DualScreen
{
  public partial class App
  {
    public App(IPlatformInitializer initializer)
      : base(initializer)
    {
    }

    protected override async void OnInitialized()
    {
      InitializeComponent();

      await NavigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(MainDualView)}");
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
      containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

      containerRegistry.RegisterForNavigation<NavigationPage>();
      containerRegistry.RegisterForNavigation<StatisticsView, StatisticsViewModel>();
      containerRegistry.RegisterForNavigation<MainDualView, MainDualViewModel>();
    }
  }
}
