using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserUC6
{
    public class MoodAnalyzer
    {
        private const string message = "I am in Sad Mood";
        private string testmessage = "";
       
        public MoodAnalyzer()
        {

        }
        public MoodAnalyzer(string msg)
        {
            this.testmessage = msg;
        }

        public string AnalyseMood()
        {

            try

            {
                if (this.testmessage == "NULL")
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.ENTERD_NULL, "Input is \"NULL\"");
                }
                else if (this.testmessage == string.Empty)
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.ENTERED_EMPTY, "Message is emptry");
                }

                else if (this.testmessage == message)
                {
                    return "SAD";
                }
                else if (this.testmessage == "I am in Happy Mood")
                {
                    return "Happy";
                }
                else
                {
                    throw new Exception("Mood is Null");
                }
            }
            catch (MoodAnalyserException e)
            {
                if (e.type == MoodAnalyserException.ExceptionType.ENTERD_NULL)
                    Console.WriteLine("catched null exception type and message is " + e.Message);
                else if (e.type == MoodAnalyserException.ExceptionType.ENTERED_EMPTY)
                    Console.WriteLine("catched empty exception type and message is " + e.Message);


                return "Happy";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "Happy";
            }


        }
    }
}
