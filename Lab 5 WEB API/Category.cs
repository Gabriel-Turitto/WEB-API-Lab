using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_WEB_API
{
    public class Category
    {
        public bool Programming { get; set; }
        public bool Miscellaneous { get; set; }
        public bool Dark { get; set; }
        public bool Pun { get; set; }
        public bool Spooky { get; set; }
        public bool Christmas { get; set; }

        public Category() { }
        public Category(bool programming, bool misc, bool dark, bool pun, bool spooky, bool christmas)
        {
            Programming = programming;
            Miscellaneous = misc;
            Dark = dark;
            Pun = pun;
            Spooky = spooky;
            Christmas = christmas;
        }

        public override string ToString()
        {
            //giving properties names
            Category categories = new Category(Programming, Miscellaneous, Dark, Pun, Spooky, Christmas);
            string msg = "";

            //getting whether each attribute is true or false
            var properties = typeof(Category).GetProperties();

            //adding the names to the string if true
            foreach (var property in properties)
            {
                bool value = (bool)property.GetValue(categories);
                if (value)
                {
                    msg += property.Name + ",";
                }
                else
                {
                    msg += "";
                }
            }

            //if no attributes are true remove the original message and replace it with Any so all categories are selected
            if (msg == "")
            {
                msg = "Any";
            }
            else
            {
                msg = msg;
            }

            //remove extra , at the end of the string
            if (!string.IsNullOrEmpty(msg) && msg != "Any")
            {
                msg = msg.Substring(0, msg.Length - 1);
            }


            return msg + "?";
        }
    }
}
