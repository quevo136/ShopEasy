using QuizzApp.Models;

namespace QuizzApp.Services
{
    public interface IQuestionService
    {
        List<Question> GetAll();
        Question GetById(int id);
        void Add(Question question);
        void Edit(Question question);       
       

    }

}
