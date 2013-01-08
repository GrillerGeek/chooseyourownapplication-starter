using System;
using System.Collections.Generic;
using ChooseYourOwn.Models;
using SRT.SignalR.Backbone;

namespace ChooseYourOwn.Hubs
{
    public class QuestionHub : BackboneModelHub<QuestionHub, Question>
    {
        private static readonly List<Question> Questions = new List<Question>();

        protected override Question CreateModel(Question model)
        {
            model.Id = Guid.NewGuid();
            Questions.Add(model);
            return model;
        }

        protected override IEnumerable<Question> FindModels()
        {
            return Questions;
        }

        protected override Question UpdateModel(Question model)
        {
            var location = Questions.FindIndex(p => p.Id == model.Id);
            if (location < 0) return model;

            Questions[location] = model;
            return model;
        }
    }
}