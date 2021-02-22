using Sample.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Sample.ViewModel
{
 public class DetailPageModel:FreshMvvm.FreshBasePageModel
  {
    ObservableCollection<DetailModel> CategoryList { get; set; }
    public string Index { get; set; }
    public DetailPageModel()
    {
      CategoryList = new ObservableCollection<DetailModel>();
      LoadData();

    }
    private void LoadData()
    {


      CategoryList.Add(new DetailModel
      {
      
        Image = "image_test.png",
      

      });
      CategoryList.Add(new DetailModel
      {
       
        Image = "bus.png",
       
      });
      CategoryList.Add(new DetailModel
      {
       
        Image = "image_test.png",
   

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
