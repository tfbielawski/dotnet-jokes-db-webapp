using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Namespace and class definition
namespace jokes.Models
{
    public class Joke
    {
        //prop + tab2x > creates property

        /// <summary>
        /// Get and set the joke id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Get/set the joke questions
        /// </summary>
        public string JokeQuestions { get; set; }
        /// <summary>
        /// Get and set the answers
        /// </summary>
        public string JokeAnswer{ get; set; }

        /// <summary>
        /// Constructor (CTOR)
        /// </summary>
        public Joke()
        {
            //Default ctor
        }
    }


    
}
