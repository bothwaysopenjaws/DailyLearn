using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyLearn.DbLib.Models;

/// <summary>
/// CLasse de contexte de données de l'application
/// </summary>
public class DailyLearnDbContext : IdentityDbContext
{
    public DailyLearnDbContext(DbContextOptions options) : base(options)
    {
    }

    /// <summary>
    /// Sujets
    /// </summary>
    public DbSet<Topic> Topics { get; set; }

    /// <summary>
    /// Utilisateurs
    /// </summary>
    public DbSet<User> AppUsers { get; set; }

    /// <summary>
    /// Liste de nos questions
    /// </summary>
    public DbSet<Question> Questions { get; set; }

}
