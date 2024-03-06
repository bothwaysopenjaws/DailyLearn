using DailyLearn.DbLib.Models;

namespace DailyLearn.WebApp.Models
{
    public class QuestionViewModel
    {
        public Question Question { get; set; }

        public List<Topic> Topics { get; set; }

        public QuestionViewModel(Question question, List<Topic> topics)
        {
            Topics = topics;
            Question = question;
        }
    }
}
