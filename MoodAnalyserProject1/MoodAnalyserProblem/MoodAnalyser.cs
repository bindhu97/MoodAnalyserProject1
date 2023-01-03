using MoodAnalyserProject1.MoodAnalyserProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        private string message;

        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyserMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.Exceptiontype.EMPTYMESSAGE, "Mood should not be Empty");
                }
                if (this.message.Contains("Sad"))
                {
                    return "Sad";
                }
                else 
                {
                    return "Happy";
                }
            }
            catch(NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.Exceptiontype.NULLMESSAGE, "Mood should not be nULL");
            }
        }
    }
}
