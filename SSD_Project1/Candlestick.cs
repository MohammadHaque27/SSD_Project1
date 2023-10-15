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
            char[] separators = new char[] { ',', ' ', '"', '-' };
            string[] subs = rowOfData.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> map = new Dictionary<string, int>();
            int i = 1;
            map.Add("Jan", i++);
            map.Add("Feb", i++);
            map.Add("Mar", i++);
            map.Add("Apr", i++);    
            map.Add("May", i++);
            map.Add("Jun", i++);
            map.Add("Jul", i++);
            map.Add("Aug", i++);
            map.Add("Sep", i++);
            map.Add("Oct", i++);
            map.Add("Nov", i++);
            map.Add("Dec", i++);
            map = new Dictionary<string, int>();  
        }
    }
}
