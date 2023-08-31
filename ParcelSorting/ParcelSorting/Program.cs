namespace ParcelSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }


        public static readonly List<BoxSize> boxSizes = new List<BoxSize>
        {
            new BoxSize
            {
                Length = 120,
                Width = 60,
                SortingLineParams = new List<SortingLineParam>
                {
                    new SortingLineParam
                    {
                        Width = 100
                    },
                    new SortingLineParam
                    {
                        Width = 75
                    }
                }
            },
            new BoxSize
            {
                Length = 100,
                Width = 35,
                SortingLineParams = new List<SortingLineParam>
                {
                    new SortingLineParam
                    {
                        Width = 75
                    },
                    new SortingLineParam
                    {
                        Width = 50
                    },
                    new SortingLineParam
                    {
                        Width = 80
                    },
                    new SortingLineParam
                    {
                        Width = 100
                    },
                    new SortingLineParam
                    {
                        Width = 37
                    }
                }
            },

            new BoxSize
            {
                Length = 70,
                Width = 50,
                SortingLineParams = new List<SortingLineParam>
                {
                    new SortingLineParam
                    {
                        Width = 60
                    },
                    new SortingLineParam
                    {
                        Width = 60
                    },
                    new SortingLineParam
                    {
                        Width = 55
                    },
                    new SortingLineParam
                    {
                        Width = 90
                    }
                }
            }
        };
    }

    

    class BoxSize
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public List<SortingLineParam> SortingLineParams { get; set; }
            = new List<SortingLineParam>();
    }

    class SortingLineParam
    {
        public int Width { get; set; }
    }
}