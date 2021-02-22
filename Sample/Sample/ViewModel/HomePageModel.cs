using Sample.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sample.ViewModel
{
 public class HomePageModel:FreshMvvm.FreshBasePageModel
  {
    public ObservableCollection<DetailModel> MyList { get; set; }
    public ICommand SelectCategoryCommand { get; set; }
    public HomePageModel()
    {
      MyList = new ObservableCollection<DetailModel>();
      SelectCategoryCommand = new Command<DetailModel>(SelectCategoryCommandExcute);
      LoadData();
    }

    private void SelectCategoryCommandExcute(DetailModel selected)
    {
      CoreMethods.PushPageModel<ShowImagesPageModel>(selected.Index);
    }

    private void LoadData()
    {
      MyList.Add(new DetailModel
      {
        Name = "hello",
        Image = "motor",
        Index="1"
      });
      MyList.Add(new DetailModel
      {
        Name = "bus satation",
        Image = "bus",
        Index = "2"
      });
     
      MyList.Add(new DetailModel
      {
        Name = "car satation",
        Image = "car",
        Index = "3"
      });
      MyList.Add(new DetailModel
      {
        Name = "Motor satation",
        Image = "motor",
        Index = "4"

      });
      MyList.Add(new DetailModel
      {
        Name = "Favourite",
        Image = "bus",
        Index = "5"
      });
      MyList.Add(new DetailModel
      {
        Name = "Motor satation",
        Image = "motor",
        Index = "6"

      });
    }
  }
}
