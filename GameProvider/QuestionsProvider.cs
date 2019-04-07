using System.Collections.Generic;
using System.Linq;

namespace Blazondo.Questions
{
    public class QuestionProvider
    {
        
        private IEnumerable<Question> _questions;
        public QuestionProvider(IEnumerable<Question> questions, Question.LevelCode level)
        {
            _questions = questions;

            this.MyQuestions = _questions
                                .Where(x=>x.video != "" )
                                .Where(x=> x.levelCode <= level )
                                .ToList();
            this.MyQuestions.ToList().ForEach( x=> {
                    x.tecnica = string.Join(" ", x.tecnica.Split(' ').Select(y=>y.ToUpper() ) );
                    x.alt = string.Join(" ", x.alt.Split(' ').Select(y=>y.ToUpper() ) );
            });

            this.AllTecniquesWords = this.MyQuestions.Select(x=>x.tecnica.Split(' ')).SelectMany(x=>x).Where(x=>x!="").ToList();
            this.AllTecniquesWords.ToList().AddRange( this.MyQuestions.Select(x=>x.alt.Split(' ')).SelectMany(x=>x).Where(x=>x!="").ToList() );

        }

        public IEnumerable<Question> MyQuestions {get;}
        public IEnumerable<string> AllTecniquesWords {get;}
             


    }
}