using Prism.Navigation;

namespace Learn.DualScreen.ViewModels
{
  public class StatisticsViewModel : ViewModelBase
  {
    public StatisticsViewModel(INavigationService navigationService)
      : base(navigationService)
    {
      Title = "Stats Page";
    }
  }
}
