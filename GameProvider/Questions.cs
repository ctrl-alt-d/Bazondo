using System.Collections.Generic;
using Newtonsoft.Json; 

namespace Blazondo.Questions
{
    public class Questions 
    {
        public IEnumerable<Question> AllQuestions => JsonConvert.DeserializeObject<IEnumerable<Question>>(AllQuestionsTxt);
        public string AllQuestionsTxt { get; }
        public Questions(string allQuestionsTxt)
        {
            AllQuestionsTxt = allQuestionsTxt;
        }
    }
}