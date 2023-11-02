using Microsoft.EntityFrameworkCore;
using OlympicGames.Data.Models;

namespace OlympicGames.Data.LogicBussiness
{
    public class DbContextOlympicGames : DbContext
    {
        public DbContextOlympicGames(DbContextOptions<DbContextOlympicGames> options) : base(options) { }
        public DbSet<ResultHalterofilia> ResultHalterofilia { get; set; }
    }
}
