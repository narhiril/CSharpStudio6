using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio6
{
    public class TrueFalse : Question
    {
        public bool Answer { get; set; }
        public TrueFalse(string prompt, bool correctResponse) : base(prompt) 
        { 
            Answer = correctResponse;
        }

        public override bool CheckAnswer(string guess)
        {
            guess = guess.ToLower().Contains('t') ? "true" : "false";
            return guess == Answer.ToString();
        }

    }
}
