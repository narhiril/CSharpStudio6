using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio6
{
    public class MultipleChoice : Question
    {
        List<string> PossibleAnswers { get; set; } = new List<string>();
        public MultipleChoice(string prompt, List<string> incorrectAnswers, string correctAnswer) : base(prompt) 
        {
            PossibleAnswers.AddRange(incorrectAnswers);
            PossibleAnswers.Add(correctAnswer);
            Answer = correctAnswer;
        }

        public override bool CheckAnswer(string guess)
        {
            int match = ToString().IndexOf($"{guess}) ");
            if (match == -1)
            {
                return false;
            }
            else
            {
                match += guess.Length + 2;
                return ToString().Substring(match, Answer.Length) == Answer;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Prompt);
            List<string> answerBank = this.PossibleAnswers.ToList();
            char start = 'a';
            foreach(string a in answerBank)
            {
                sb.AppendLine($"{this.GetNextCharacter(start)}) {a}");
            }
            return sb.ToString();

        }

        private char GetNextCharacter(char input)
        {
            return input == 'z' ? 'a' : (char)((int)input + 1);
        }

        private List<string> Randomize()
        {
            Random rng = new Random();
            List<string> output = PossibleAnswers.OrderBy(x => rng.Next()).ToList();
            return output;
        }
    }
}
