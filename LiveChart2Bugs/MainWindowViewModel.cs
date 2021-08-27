using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LiveChart2Bugs
{
    class Page
    {
        public string Name { get; set; }
        public object Content { get; set; }
    }

    class MainWindowViewModel
    {
        public List<Page> Pages { get; set; } 

        public Page SelectedPage { get; set; }

        public MainWindowViewModel()
        {
            Pages = new List<Page>
            {
                new Page { Name = "Multiple Axis Out Of Range", Content = new OutOfRangeChartVM() },
                new Page { Name = "Series NotVisible Chart", Content = new SeriesNotVisibleChartVM() },
                new Page { Name = "Empty page", Content = new object() },
            };

            SelectedPage = Pages[1];
        }
    }
}
