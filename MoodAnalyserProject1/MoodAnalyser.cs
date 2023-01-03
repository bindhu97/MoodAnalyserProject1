using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProject1
{
    internal class MoodAnalyser
    {
        public string AnalyseMood(string message)
        {
            if (message.ToLower().Contains("Sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }
    }
}
