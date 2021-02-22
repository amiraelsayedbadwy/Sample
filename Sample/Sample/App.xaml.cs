using FreshMvvm;
using Sample.ViewModel;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sample
{
  public partial class App : Application
  {
    public App()
    {
      InitializeComponent();

      var page = FreshPageModelResolver.ResolvePageModel<HomePageModel>();
      MainPage = new FreshNavigationContainer(page);
    }

    protected override void OnStart()
    {
    }

    protected override void OnSleep()
    {
    }

    protected override void OnResume()
    {
    }
  }
}
