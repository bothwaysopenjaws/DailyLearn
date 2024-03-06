using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyLearn.DbLib.Models;

/// <summary>
/// Classe de base
/// </summary>
abstract class IdentityObject
{
    /// <summary>
    /// Identifiant
    /// </summary>
    [Key]
    public int Id { get; set; }
}
