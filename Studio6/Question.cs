using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio6
{
    public abstract class Question
    {
        public string Prompt { get; set; }
        public string Answer { get; set; }

        public Question(string prompt)
        {
            Prompt = prompt;
        }

        public abstract bool CheckAnswer(string guess);

        public override string ToString()
        {
            return Prompt; //Fix me
        }

    }
}
