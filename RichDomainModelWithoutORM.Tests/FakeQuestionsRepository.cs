using System.Collections.Generic;
using System.Linq;
using RichDomainModelWithoutORM.Domain;

namespace RichDomainModelWithoutORM.Tests
{
    internal class FakeQuestionsRepository : IQuestionRepository
    {
        public IEnumerable<Question> GetRandomForCategory(string categoryName, int nbQuestions)
        {
            return Enumerable.Range(1, 50)
                .Select(x => new Question(x, "some question", "its answer")).ToList();
        }
    }
}
