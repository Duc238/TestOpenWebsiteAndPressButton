using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestOpenWebsiteAndPressButton.ViewModel;

namespace TestOpenWebsiteAndPressButton.Model
{
    public class SettingData : BaseViewModel
    {
        private int _TotalData;
        public int TotalData
        {
            get => _TotalData;
            set
            {

                _TotalData = value;
                OnPropertyChanged();
            }
        }
    }
}
