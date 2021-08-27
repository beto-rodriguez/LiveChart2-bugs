using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.WPF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LiveChart2Bugs
{
    class SeriesNotVisibleChartVM
    {
        public List<ISeries> Series { get; set; }
        public ICommand Redraw { get; set; }

        public SeriesNotVisibleChartVM()
        {
            Series = new List<ISeries>()
            {
                new LineSeries<double>
                {
                    Values = new double[] { 0,1 , 2 ,4 ,5 ,1 ,0 ,4 ,0.4 ,3 ,2 ,1 ,1 ,3 ,2 ,1 ,2 ,1.2 ,1.21 ,1 },
                }
            };

            Redraw = new RelayCommand(() =>
            {
                Series.ForEach(serie => serie.IsVisible = true);
            }, () => true);
        }
    }
}
