using ParcelSorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxSortingLine.Test
{
    public class BoxSortingTest
    {
        public void When_ParcelHasNewDimensionsAndSortingLineHasNewDimensions_ThenParcelCanNotFitSortingLine()
        {
            var boxSizes = new List<BoxSize>()
            {
                new BoxSize
                {
                    Length = 70,
                    Width = 50,
                    SortingLineParams = new List<SortingLineParam>()
                    {
                        new SortingLineParam
                        {
                            LineWidth = 50,
                        },
                        new SortingLineParam
                        {
                            LineWidth = 50,
                        },
                        new SortingLineParam
                        {
                            LineWidth = 100,
                        },
                        new SortingLineParam
                        {
                            LineWidth = 100,
                        }
                    }
                }
            };
        }
    }
}
