﻿using System;
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
                if (this.message.ToLower().Contains("sad"))
                {
                    return "sad";
                }
                else
                {
                    return "happy";
                }
            }
            catch
            {
                return "happy";
            }
        }
    }
}
