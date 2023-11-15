using System.Net.NetworkInformation;
using System.Text.Json;
using System.Threading;

namespace Lab_5_WEB_API
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            string apiCall = "https://v2.jokeapi.dev/joke/";

            Category categories = new Category(false, false, false, false,false, false);

            int categoryChoice = 0;

            string programming = "\n1. Programming";
            string misc = "\n2. Miscellaneous";
            string dark = "\n3. Dark";
            string pun = "\n4. Pun";
            string spooky = "\n5. Spooky";
            string christmas = "\n6. Christmas";

            while (categoryChoice != 7) 
            {
                Console.WriteLine("Choose what category of joke you would like (leaving them blank chooses them all)" +
                    $"{programming}" +
                    $"{misc}" +
                    $"{dark}" +
                    $"{pun}" +
                    $"{spooky}" +
                    $"{christmas}" +
                    "\n7. Move on to the next question");

                categoryChoice = Convert.ToInt32(Console.ReadLine());

                if (categoryChoice == 1)
                {
                    if (categories.Programming == false)
                    {
                        categories.Programming = true;
                        programming = "\n1. Programming (selected)";
                    }
                    else
                    {
                        categories.Programming = false;
                        programming = "\n1. Programming";
                    }
                }
                else if (categoryChoice == 2)
                {
                    if (categories.Miscellaneous == false)
                    {
                        categories.Miscellaneous = true;
                        misc = "\n2. Miscellaneous (selected)";
                    }
                    else
                    {
                        categories.Miscellaneous = false;
                        misc = "\n2. Miscellaneous";
                    }
                }
                else if (categoryChoice == 3)
                {
                    if (categories.Dark == false)
                    {
                        categories.Dark = true;
                        dark = "\n3. Dark (selected)";
                    }
                    else
                    {
                        categories.Dark = false;
                        dark = "\n3. Dark";
                    }
                }
                else if (categoryChoice == 4)
                {
                    if (categories.Pun == false)
                    {
                        categories.Pun = true;
                        pun = "\n4. Pun (selected)";
                    }
                    else
                    {
                        categories.Pun = false;
                        pun = "\n4. Pun";
                    }
                }
                else if (categoryChoice == 5)
                {
                    if (categories.Spooky == false)
                    {
                        categories.Spooky = true;
                        spooky = "\n5. Spooky (selected)";
                    }
                    else
                    {
                        categories.Spooky = false;
                        spooky = "\n5. Spooky";
                    }
                }
                else if (categoryChoice == 6)
                {
                    if (categories.Christmas == false)
                    {
                        categories.Christmas = true;
                        christmas = "\n6. Christmas (selected)";
                    }
                    else
                    {
                        categories.Christmas = false;
                        christmas = "\n6. Christmas";
                    }
                }
                Console.Clear();
            }

            apiCall += categories;

            string language = "";
            int languageChoice = 0;

            string cs = "\n1. Czech";
            string de = "\n2. German";
            string en = "\n3. English";
            string es = "\n4. Spanish";
            string fr = "\n5. French";
            string pt = "\n6. Portugese";

            while(languageChoice != 7)
            {
                Console.WriteLine($"What language do you want the joke to be in?" + cs + de + en + es + fr + pt + "\n7. Move on to the next question");
                languageChoice = Convert.ToInt32(Console.ReadLine());
                if(languageChoice == 1)
                {
                    cs = "\n1. Czech (selected)";
                    de = "\n2. German";
                    en = "\n3. English";
                    es = "\n4. Spanish";
                    fr = "\n5. French";
                    pt = "\n6. Portugese";

                    language = "lang=cs";
                }
                else if(languageChoice == 2)
                {
                    cs = "\n1. Czech";
                    de = "\n2. German (selected)";
                    en = "\n3. English";
                    es = "\n4. Spanish";
                    fr = "\n5. French";
                    pt = "\n6. Portugese";

                    language = "lang=de";
                }
                else if(languageChoice == 3)
                {
                    cs = "\n1. Czech";
                    de = "\n2. German";
                    en = "\n3. English (selected)";
                    es = "\n4. Spanish";
                    fr = "\n5. French";
                    pt = "\n6. Portugese";

                    language = "lang=en";
                }
                else if(languageChoice == 4)
                {
                    cs = "\n1. Czech";
                    de = "\n2. German";
                    en = "\n3. English";
                    es = "\n4. Spanish (selected)";
                    fr = "\n5. French";
                    pt = "\n6. Portugese";

                    language = "lang=es";
                }
                else if(languageChoice == 5)
                {
                    cs = "\n1. Czech";
                    de = "\n2. German";
                    en = "\n3. English";
                    es = "\n4. Spanish";
                    fr = "\n5. French (selected)";
                    pt = "\n6. Portugese";

                    language = "lang=fr";
                }
                else if(languageChoice == 6)
                {
                    cs = "\n1. Czech";
                    de = "\n2. German";
                    en = "\n3. English";
                    es = "\n4. Spanish";
                    fr = "\n5. French";
                    pt = "\n6. Portugese (selected)";

                    language = "lang=pt";
                }
                Console.Clear();
            }

            apiCall += language;

            Flags flags = new Flags(false, false, false, false, false, false);

            int flagChoice = 0;

            string nsfw = "\n1. Nsfw";
            string religious = "\n2. Religious";
            string political = "\n3. Political";
            string racist = "\n4. Racist";
            string sexist = "\n5. Sexist";
            string exp = "\n6. Explicit";

            



            while (flagChoice != 7)
            {
                Console.WriteLine("Choose flags to blacklist (Enter the number): " +
                    $"{nsfw}" +
                    $"{religious}" +
                    $"{political}" +
                    $"{racist}" +
                    $"{sexist}" +
                    $"{exp}" +
                    "\n7. Move on to the next question");

                flagChoice = Convert.ToInt32(Console.ReadLine());

                if (flagChoice == 1)
                {
                    if (flags.Nsfw == false)
                    {
                        flags.Nsfw = true;
                        nsfw = "\n1. Nsfw (blacklisted)";
                    }
                    else
                    {
                        flags.Nsfw = false;
                        nsfw = "\n1. Nsfw";
                    }
                }
                else if (flagChoice == 2)
                {
                    if (flags.Religious == false)
                    {
                        flags.Religious = true;
                        religious = "\n2. Religious (blacklisted)";
                    }
                    else
                    {
                        flags.Religious = false;
                        religious = "\n2. Religious";
                    }
                }
                else if (flagChoice == 3)
                {
                    if (flags.Political == false)
                    {
                        flags.Political = true;
                        political = "\n3. Political (blacklisted)";
                    }
                    else
                    {
                        flags.Political = false;
                        political = "\n3. Political";
                    }
                }
                else if (flagChoice == 4)
                {
                    if (flags.Racist == false)
                    {
                        flags.Racist = true;
                        racist = "\n4. Racist (blacklisted)";
                    }
                    else
                    {
                        flags.Racist = false;
                        racist = "\n4. Racist";
                    }
                }
                else if (flagChoice == 5)
                {
                    if (flags.Sexist == false)
                    {
                        flags.Sexist = true;
                        sexist = "\n5. Sexist (blacklisted)";
                    }
                    else
                    {
                        flags.Sexist = false;
                        sexist = "\n5. Sexist";
                    }
                }
                else if (flagChoice == 6)
                {
                    if (flags.Explicit == false)
                    {
                        flags.Explicit = true;
                        exp = "\n6. Explicit (blacklisted)";
                    }
                    else
                    {
                        flags.Explicit = false;
                        exp = "\n6. Explicit";
                    }
                }
                Console.Clear();
            }

            if(flags.Nsfw == false && flags.Sexist == false && flags.Political == false && flags.Racist == false
                && flags.Explicit == false && flags.Religious == false)

            {
                apiCall += flags;
            }
            else
            {
                apiCall += "&" + flags;
            }

            int partChoice = 0;

            string onePart = "\n1. One part";
            string twoPart = "\n2. Two part";

            string finalPartChoice = "";

            while (partChoice != 3)
            {
                Console.WriteLine("Do you want a one or two part joke?" +
                onePart + twoPart + "\n3. Move on to the last question");

                partChoice = Convert.ToInt32(Console.ReadLine());

                if (partChoice == 1)
                {
                    onePart = "\n1. One part (selected)";
                    twoPart = "\n2. Two part";

                    finalPartChoice = "type=single";
                }
                else if (partChoice == 2)
                {
                    onePart = "\n1. One part";
                    twoPart = "\n2. Two part (selected)";

                    finalPartChoice = "type=twopart";
                }
                Console.Clear();
            }

            apiCall += "&" + finalPartChoice;

            if (finalPartChoice == "type=single")
            {
                await SingleJokeCall(apiCall);
            }
            else if(finalPartChoice == "type=twopart")
            {
                await TwoPartJokeCall(apiCall);
            }
            else
            {
                Console.WriteLine("Here you can have one of each: ");

                await SingleJokeCall(apiCall);
                await TwoPartJokeCall(apiCall);
            }

        }

        public static async Task TwoPartJokeCall(string apiCall)
        {
            // sending our request to https://v2.jokeapi.dev/joke/Any?type=twopart

            // create a HttpClient object to use to send the request
            var client = new HttpClient();

            string apiLinkCall = "https://v2.jokeapi.dev/joke/Any?type=twopart";

            // Receive a response and store it in a variable
            // use 'await' when accessing an async method / resource
            HttpResponseMessage response = await client.GetAsync(apiLinkCall);

            // store body of the response in a variable (this is our json)
            string json = await response.Content.ReadAsStringAsync();

            // Deserialize = pulling a .NET object out of json
            // Serialize = create json from a .NET object

            // capitalization of properties doesn't matter with this option, as long as the prop names
            // match the json keys
            var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

            TwoPartJoke p = JsonSerializer.Deserialize<TwoPartJoke>(json, options);
            Console.WriteLine(p + "\n");


        }
        public static async Task SingleJokeCall(string apiCall)
        {
            // sending our request to https://v2.jokeapi.dev/joke/Any?type=single

            // create a HttpClient object to use to send the request
            var client = new HttpClient();

            string apiLinkCall = "https://v2.jokeapi.dev/joke/Any?type=single";

            // Receive a response and store it in a variable
            // use 'await' when accessing an async method / resource
            HttpResponseMessage response = await client.GetAsync(apiLinkCall);

            // store body of the response in a variable (this is our json)
            string json = await response.Content.ReadAsStringAsync();

            // Deserialize = pulling a .NET object out of json
            // Serialize = create json from a .NET object

            // capitalization of properties doesn't matter with this option, as long as the prop names
            // match the json keys
            var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

            SingleJoke p = JsonSerializer.Deserialize<SingleJoke>(json, options);
            Console.WriteLine(p + "\n");


        }
    }
}