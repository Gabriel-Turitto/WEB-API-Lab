using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_WEB_API
{
    public class TwoPartJoke
    {
        public bool Error { get; set; }
        public string SetUp { get; set; }
        public string Delivery { get; set; }


        public TwoPartJoke() { }
        public TwoPartJoke(bool error, string setUp, string delivery)
        {
            Error = error;
            SetUp = setUp;
            Delivery = delivery;
        }

        public override string ToString()
        {
            string joke = "";

            if (!Error)
            {
                joke += $"Setup: {SetUp}\n";
                joke += $"Delivery: {Delivery}";
            }
            else
            {
                joke += "There was no joke matching that criteria. L time to go back through that long ass process";
            }

            

            return joke;
        }

    }

}
