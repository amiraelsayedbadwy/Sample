using Sample.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Sample.ViewModel
{
 public class ShowImagesPageModel:FreshMvvm.FreshBasePageModel
  {
   public ObservableCollection<DetailModel> CategoryList { get; set; }
    public string Index { get; set; }
    public ShowImagesPageModel()
    {
      CategoryList = new ObservableCollection<DetailModel>();
      LoadData();

    }
    private void LoadData()
    {


      CategoryList.Add(new DetailModel
      {

        Image = "sunset.jpg",


      });
      CategoryList.Add(new DetailModel
      {

        Image = "sunset.jpg",

      });
      CategoryList.Add(new DetailModel
      {

        Image = "sunset.jpg",


      });
    }
    public override void Init(object initData)
    {
      base.Init(initData);
      var data = initData as string;
      if (data != null)
        Index = data;
    }

  }
}