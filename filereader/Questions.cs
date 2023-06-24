using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filereader
{
    public class Questions
    {
        public Questions() { }
        public string Category { get; set; }
        public string Quest { get; set; }
        public string AnsA { get; set; }
        public string AnsB { get; set; }
        public string AnsC { get; set; }
        public string AnsD { get; set; }
        public Questions(string Quest)
        {
            this.Quest = Quest;
        }
        public Questions(string Quest, string AnsA)
        {
            this.Quest = Quest;
            this.AnsA = AnsA;
        }
        public Questions(string Quest, string AnsA, string AnsB)
        {
            this.Quest = Quest;
            this.AnsA = AnsA;
            this.AnsB = AnsB;
        }
        public Questions(string Quest, string AnsA, string AnsB, string AnsC)
        {
            this.Quest = Quest;
            this.AnsA = AnsA;
            this.AnsB = AnsB;
            this.AnsC = AnsC;
        }
        public Questions(string Quest, string AnsA, string AnsB, string AnsC, string AnsD)
        {
            this.Category = Category;
            this.Quest = Quest;
            this.AnsA = AnsA;
            this.AnsB = AnsB;
            this.AnsC = AnsC;
            this.AnsD = AnsD;
        }
        public override string ToString()
        {
            String message ="Ques: " + Quest + "\nA." + AnsA + "\nB." + AnsB + "\nC." + AnsC + "\nD." + AnsD + "\n";
            return message.ToString();
        }
    }
}
