using System;
using System.Collections.Generic;

namespace ChooseYourOwn.Models
{
    public class Question
    {
        public Question()
        {
            Votes = new List<Vote>();
        }

        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Text { get; set; }
        public List<Vote> Votes { get; set; }
    }
}