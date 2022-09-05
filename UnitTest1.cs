namespace MoodAnalyserUC6
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MoodAnalyse()
        {
            string meassage = "I am in Sad Mood";
            MoodAnalyser moodAnalyzer = new MoodAnalyzer(meassage);
            string ExpectedOutput = "SAD";

            string result = moodAnalyzer.AnalyseMood();

            Assert.AreEqual(result, ExpectedOutput);
        }
    }
}