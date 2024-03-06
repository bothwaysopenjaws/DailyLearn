﻿using System;
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
    internal class Question : IdentityObject
    {
        /// <summary>
        /// Question à poser
        /// </summary>
        public string QuestionAsked { get; set; }

        /// <summary>
        /// Url d'un éventuel média
        /// </summary>
        public string? UrlMedia { get; set; }

        /// <summary>
        /// Réponses possibles
        /// </summary>
        public HashSet<string> PossibleAnswers { get; set; }

        /// <summary>
        /// Réponses valides
        /// </summary>
        public HashSet<string> ValidAnswer { get; set; }

        /// <summary>
        /// Identifiant du sujet
        /// </summary>
        [ForeignKey(nameof(Question.Topic))]
        public int TopidId { get; set; }

        /// <summary>
        /// Sujet
        /// </summary>
        public Topic Topic { get; set; }

    }
}
