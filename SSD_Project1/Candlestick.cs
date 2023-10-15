using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSD_Project1
{
    internal class Candlestick
    {

        public Decimal open;
        public Decimal close;
        public Decimal high;
        public Decimal low;
        public long volume;
        public DateTime date;

        //Default constructor, you can call it without any arguments
        public Candlestick() { }

        public Candlestick(decimal open = 0) // optional parameters
        {
            this.open = open;
        }
        public Candlestick(DateTime date, decimal open = 0, decimal close = 0, decimal high = 0, decimal low = 0, long volume = 0)
        {
            this.date = date;
            this.open = open;
            this.close = close;
            this.high = high;
            this.low = low;
            this.volume = volume;
        }
        public Candlestick(String rowOfData)
        {

        }
    }
}
