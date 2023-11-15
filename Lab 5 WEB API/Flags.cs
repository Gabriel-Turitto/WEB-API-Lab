using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_WEB_API
{
    public class Flags
    {
        public bool Nsfw { get; set; }
        public bool Religious { get; set; }
        public bool Political { get; set; }
        public bool Racist { get; set; }
        public bool Sexist { get; set; }
        public bool Explicit { get; set; }

        public Flags()
        {

        }
        public Flags(bool nsfw, bool religious, bool political, bool racist, bool sexist, bool explic)
        {
            Nsfw = nsfw;
            Religious = religious;
            Political = political;
            Racist = racist;
            Sexist = sexist;
            Explicit = explic;
        }

        public override string ToString()
        {
            //giving properties names
            Flags flags = new Flags(Nsfw, Religious, Political, Racist, Sexist, Explicit);
            string msg = "blacklistFlags=";

            //getting whether each attribute is true or false
            var properties = typeof(Flags).GetProperties();

            //adding the names to the string if true
            foreach (var property in properties)
            {
                bool value = (bool)property.GetValue(flags);
                if(value)
                {
                    msg += property.Name.ToLower() + ",";
                }
                else
                {
                    msg += "";
                }
            }

            //if no attributes are true remove the original message and replace it with empty string
            if (msg == "blacklistFlags=")
            {
                msg = "";
            }
            else
            {
                msg = msg;
            }

            //remove extra , at the end of the string
            if (!string.IsNullOrEmpty(msg) && msg != "")
            {
                msg = msg.Substring(0, msg.Length - 1);
            }
            
            
            return msg;
        }



    }
}
