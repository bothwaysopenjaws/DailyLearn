using DailyLearn.DbLib.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DailyLearn.WebApp.Data
{
    public class DailyLearnWebAppDbContext : DailyLearnDbContext
    {
        public DailyLearnWebAppDbContext(DbContextOptions<DailyLearnWebAppDbContext> options)
            : base(options)
        {
        }
    }
}
