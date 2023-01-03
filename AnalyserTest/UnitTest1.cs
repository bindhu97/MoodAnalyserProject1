namespace AnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            [TestMethod]
            [TestCategory("Happy Mood")]
            public void TestMethodAnalyserForHappyMood()
            {
                string message = "Im in sad mood";
                string expected = "sad";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);

                string Actual = moodAnalyser.Analyser();

                Assert.AreEqual(Actual, "Sad");
            }
            //UT1.2
            [TestMethod]
            [TestCategory("Any Mood")]
            public void TestMethodAnalayserForSadMood()
            {
                string message = "Im in any mood";
                string expected = "Happy";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);

                string Actual = moodAnalyser.Analyser();

                Assert.AreEqual(Actual, "Happy");
            }
        }
    }
}