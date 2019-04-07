using System;
using System.Linq;
using Blazondo.Questions;
using Xunit;

namespace GameProvider.Test
{
    public class UnitTestQuestionsProvider
    {
        [Fact]
        public void CanLoadQuestions()
        {
            var Q = new Questions();
            var MyQ = Q.AllQuestions;
            Assert.True(MyQ.Count()>0, "Should be questions");
        }
        [Fact]
        public void AllLevelsPresents()
        {
            var Q = new Questions();
            var MyQ = Q.AllQuestions;
            Assert.True(MyQ.Select(x=>x.level).Distinct().Count()==6, "6 levels should be pressent");
        }
    }
}
