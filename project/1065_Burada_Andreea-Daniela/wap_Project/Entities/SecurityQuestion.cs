using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wap_Project.Entities
{
    public class SecurityQuestion
    {
        public int questionId { get; set; }
        public string question_answer { get; set; }

        public static List<string> all_questions = new List<string>(new string[]{
            "What is the name of the town you were born in?",
            "What is the name of your first pet?",
            "What is your mother's maiden name?",
            "What is the name of your childhood friend?",
            "What is your favorite colour?" });

        public SecurityQuestion() { }

        public SecurityQuestion(int index, string a)
        {
            question_answer = a;
            questionId = index;
        }
    }
}
