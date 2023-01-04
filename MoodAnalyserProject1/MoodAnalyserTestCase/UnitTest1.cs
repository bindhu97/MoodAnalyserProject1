using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;
using MoodAnalyserProject1;
using MoodAnalyserProject1.MoodAnalyserProblem;

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
        [TestMethod]
        //TC3.1
        public void TestMethodNullMoodShouldThrowMoodAnalysisException()
        {
            try
            {
                string message = null;
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string mood = moodAnalyser.AnalyserMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }
        [TestMethod]
        //TC3.2
        public void TestMethodEmptyMoodShouldThrowMoodAnalysisException()
        {
            try
            {
                string message = "";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string mood = moodAnalyser.AnalyserMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }
        //TC4.1
        [TestMethod]
        public void TestMethodClassNameShouldReturnMoodAnalyserObject()
        {
            object expected = new MoodAnalyser();
            object obj = MoodAnalyserFactory.CreateMoodAnalysis("MoodAnalyserProbelm.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }
        //TC4.2
        [TestMethod]
        public void TestMethodClassNameImproperShouldThrowMoodAnalyserException()
        {
            try
            {
                object expected = new MoodAnalyser();
                object obj = MoodAnalyserFactory.CreateMoodAnalysis("erMoodAnalyserProbelm.MoodAnalys", "MoodAnalyser");
                expected.Equals(obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //TC4.3
        [TestMethod]
        public void TestMethodConstructorNameImproperShouldThrowMoodAnalyserException()
        {
            try
            {
                object expected = new MoodAnalyser();
                object obj = MoodAnalyserFactory.CreateMoodAnalysis("MoodAnalyserProbelm.AnalyseMood", "MoodAnalyser");
                expected.Equals(obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}