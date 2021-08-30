using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LiveChart2Bugs
{
    class NoTooltipObservablePointEnumerableVM
    {
        public List<ISeries> Series { get; set; }

        public NoTooltipObservablePointEnumerableVM()
        {
            Series = new List<ISeries>()
            {
                new LineSeries<ObservablePoint>
                {
                    Values = new List<ObservablePoint>
                    { 
                        new ObservablePoint(0, 0),
                        new ObservablePoint(1, 1),
                        new ObservablePoint(2, 2),
                    },
                },
                new LineSeries<ObservablePoint>
                {
                    Values = Enumerable.Range(0, 3).Select(i => new ObservablePoint(i, i * 2)),
                },
                new LineSeries<ObservablePoint>
                {
                    Values = Enumerable.Range(0, 3)
                                        .Select(i => new ObservablePoint(i, i * 3))
                                        .ToList(),
                }
            };
        }
    }
}
