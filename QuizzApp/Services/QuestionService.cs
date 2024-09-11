using QuizzApp.Context;
using QuizzApp.Models;

namespace QuizzApp.Services
{
    public class QuestionService : IQuestionService
    {
        private AppDbContext _appDbContext;
        public QuestionService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Add(Question question)
        {
            _appDbContext.Questions.Add(question);
            _appDbContext.SaveChanges();
        }

        public void Edit(Question question)
        {
            throw new NotImplementedException();
        }

        public List<Question> GetAll() => _appDbContext.Questions.ToList();
        public Question GetById(int id) => _appDbContext.Questions.FirstOrDefault(x => x.Id == id);

    }
}
