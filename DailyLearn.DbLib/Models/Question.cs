using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyLearn.DbLib.Models
{
    /// <summary>
    /// Question d'un sujet
    /// </summary>
    public class Question : IdentityObject
    {
        /// <summary>
        /// Question à poser
        /// </summary>
        public string QuestionToAsk { get; set; }

        /// <summary>
        /// Réponses possibles
        /// </summary>
        public List<Answer> PossibleAnswers { get; set; }

        /// <summary>
        /// Identifiant du sujet
        /// </summary>
        [ForeignKey(nameof(Question.Topic))]
        public int TopicId { get; set; }

        /// <summary>
        /// Sujet
        /// </summary>
        public virtual Topic? Topic { get; set; }

        public Question()
        {
            PossibleAnswers = new();
        }

    }
}
