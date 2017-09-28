using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Org.Zpf.XFeiCards.UI.Implement
{
   public  class ComboxItemValue:ObservableCollection<int>
    {
        public ComboxItemValue():base(){
            Add(2);
            Add(3);
            Add(4);
            Add(5);
        }
    }
}
