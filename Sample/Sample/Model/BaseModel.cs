using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Sample.Model
{
 public class BaseModel : INotifyPropertyChanged
  {
    public int Id { get; set; }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
    {
      PropertyChangedEventHandler handler = PropertyChanged;
      if (handler != null)
      {
        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
      }
    }
  }
}
