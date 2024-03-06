using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyLearn.DbLib.Models
{
    /// <summary>
    /// Sujet
    /// </summary>
    internal class Topic
    {

        /// <summary>
        /// Nom du sujet
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Listes de questions sur un sujet
        /// </summary>
        public List<Question> Questions { get; set; }

    }
}
