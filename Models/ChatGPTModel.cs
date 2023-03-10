using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatGPT.Models
{
    public class ChatGPTModel
    {
        public int Token { get; set; }
        public string Input { get; set; }
        public string Engine { get; set; }
        public double Temperature { get; set; }
        public int TopP { get; set; }
        public int FrequencyPenalty { get; set; }
        public int PresencePenalty { get; set; }
    }
    public class Response
    {
        public int ID { get; set; }
        public string Answer { get; set; }
        public string Question { get; set; }
    }
}
