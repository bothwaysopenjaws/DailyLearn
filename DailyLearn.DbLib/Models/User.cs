using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyLearn.DbLib.Models;


/// <summary>
/// Utilisateur de l'application
/// </summary>
internal class User : IdentityUser
{
    /// <summary>
    /// Pseudo de l'utilisateur
    /// </summary>
    public string Pseudo { get; set; }

    /// <summary>
    /// Constructeur d'un utilisateur
    /// </summary>
    /// <param name="pseudo"></param>
    public User(string pseudo) : base()
    {
        Pseudo = pseudo;
    }
}
