using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyLearn.DbLib.Models;

/// <summary>
/// Sujet
/// </summary>
internal class Topic : IdentityObject
{

    /// <summary>
    /// Nom du sujet
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Listes de questions sur un sujet
    /// </summary>
    public List<Question> Questions { get; set; }

    /// <summary>
    /// Constructeur d'un sujet
    /// </summary>
    public Topic(string name)
    {
        Name = name;
        Questions = new List<Question>();
    }
}
