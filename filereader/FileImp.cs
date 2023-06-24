using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Collections.Generic;

namespace filereader
{
    public class FileImp : IFile
    {
        private string fileName = "Questions.txt";
        public void SaveDataToFile(string fileName, List<Questions> questions)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var question in questions)
            {
                builder.AppendLine(question.Quest);
                builder.AppendLine(question.AnsA);
                builder.AppendLine(question.AnsB);
                builder.AppendLine(question.AnsC);
                builder.AppendLine(question.AnsD);
            }
            File.AppendAllText(fileName, builder.ToString());
        }

        public List<Questions> LoadDataFromFile()
        {
            List<Questions> questions = new List<Questions>();
            try
            {
                var data = File.ReadAllText(fileName).Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < data.Length; i++)
                {
                    Questions question = new Questions(data[i], data[i + 1], data[i + 2], data[i + 3], data[i + 4]);
                    questions.Add(question);
                    i += 4;
                }
            }
            catch (Exception)
            {

            }
            return questions;
        }
        public void MakeQuizz(List<Questions> questions)
        {
            Random random = new Random();
            FileImp fileImp = new FileImp();
            List<Questions> questionsForQuizz = new List<Questions>();
            for (int i = 0; i < 3; i++)
            {
                int randomIndex = random.Next(0, questions.Count);
                Questions randomElement = questions[randomIndex];
                questionsForQuizz.Add(randomElement);
            }
            fileImp.SaveDataToFile("Quizz.txt", questionsForQuizz);
        }
        //public static void Main()
        //{
        //    FileImp fileImp = new FileImp();
        //    List<Questions> questions = new List<Questions>();
        //    List<Questions> questionsForQuizz = new List<Questions>();
        //    //Questions question = new Questions("1+2=?", "1", "2", "3", "4");
        //    //questions.Add(question);
        //    //Console.WriteLine(question.ToString());
        //    questions = fileImp.LoadDataFromFile();
        //    //for (int i = 0; i < questions.Count; i++)
        //    //{
        //    //    Console.WriteLine(questions[i].ToString());
        //    //}
        //    fileImp.MakeQuizz(questions);
        //}
    }
}
