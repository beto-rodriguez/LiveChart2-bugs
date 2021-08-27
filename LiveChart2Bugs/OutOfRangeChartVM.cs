using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveChart2Bugs
{
    class OutOfRangeChartVM
    {
        public List<ISeries> Series { get; set; }
        public List<Axis> YAxes { get; set; }

        public OutOfRangeChartVM()
        {
            YAxes = new List<Axis>
            {
                new Axis(), new Axis()
            };

            Series = new List<ISeries>()
            {
                new LineSeries<double>
                {
                    Values = new double[] { 0,1 , 2 ,4 ,5 ,1 ,0 ,4 ,0.4 ,3 ,2 ,1 ,1 ,3 ,2 ,1 ,2 ,1.2 ,1.21 ,1 },
                    ScalesYAt = 0,

                },
                new LineSeries<double>
                {
                    Values = new double[] { 2, 1, 0, 1, 2, 3, 1, 2, 5.4, 3.5, 0, 2, 0.1, -1, 2, 1,2, 2.2, 3.21, 0 },
                    ScalesYAt = 1,
                }
            };
        }
    }
}
