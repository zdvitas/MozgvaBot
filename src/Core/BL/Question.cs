using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MozgvaBot.Core.BL
{
    [Serializable]
    public class Question
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public IList<string> Answers { get; set; }
        
        public string CorrectAnswer { get; set; }
    }
}
