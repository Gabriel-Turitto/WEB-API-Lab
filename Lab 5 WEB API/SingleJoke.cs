using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_WEB_API
{
    public class SingleJoke
    {
        public bool Error { get; set; }
        public string Joke { get; set; }

        public SingleJoke() { }

        public SingleJoke(bool error, string joke)
        {
            Error = error;
            Joke = joke;
        }

        public override string ToString()
        {
            string jokeMsg = "";

            if (!Error) 
            {
                jokeMsg += Joke;
            }
            else if (Error)
            {
                jokeMsg += "There was no joke matching that criteria. L time to go back through that long ass process";
            }

            return jokeMsg;
        }
    }
}
