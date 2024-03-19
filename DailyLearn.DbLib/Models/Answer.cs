using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyLearn.DbLib.Models;

/// <summary>
/// Réponse d'une question
/// </summary>
public class Answer : IdentityObject
{
    public string? Name { get; set; }

    [ForeignKey(nameof(Answer.Question))]
    public int QuestionId { get; set; }

    public virtual Question? Question { get; set; }

    public bool IsCorrect { get; set; }

}
