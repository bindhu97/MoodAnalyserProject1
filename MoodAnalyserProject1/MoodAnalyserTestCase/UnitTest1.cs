using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;

namespace MoodAnalyserTestCase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //TC1.1
        [TestCategory("Sad Mood")]
        public void TestMethodAnalyzerForSadMood()
        {
            ///AAA methodology
            ///Arrange
            string message = "Im in sad mood";

            //Act
            MoodAnalyser analyser = new MoodAnalyser(message);
            string Actual = analyser.AnalyserMood();

            //Assert
            Assert.AreEqual(Actual, "sad");
        }
        [TestMethod]
        //TC1.2
        [TestCategory("In Any Mood")]
        public void TestMethodAnalayzerForAnyMood()
        {
            ///AAA methodology
            ///arrange
            string message = "Im in any mood";

            //Act
            MoodAnalyser analyser = new MoodAnalyser(message);
            string Actual = analyser.AnalyserMood();

            //Assert
            Assert.AreEqual(Actual, "happy");
        }
        [TestMethod]
        //TC2.1
        [DataRow("I am in Happy Mood")]
        [DataRow(null)]
        public void TestMethodAnalayzerForHappyMood()
        {
            ///AAA methodology
            ///arrange
            string message = "Im in Happy mood";

            //Act
            MoodAnalyser analyser = new MoodAnalyser(message);
            string Actual = analyser.AnalyserMood();

            //Assert
            Assert.AreEqual(Actual, "Happy");
        }
    }
}