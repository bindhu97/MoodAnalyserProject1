// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using MoodAnalyserProject1;

string message1 = "I am in Sad mood";
MoodAnalyser mood1 = new MoodAnalyser(message1);
mood1.Analyser();

string message2 = "I am in any mood";
MoodAnalyser mood2 = new MoodAnalyser(message2);
mood2.Analyser();
