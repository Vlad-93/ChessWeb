using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Chess
{
    class SampleContext : DbContext
    {
        public SampleContext() : base("Chess")
        { }
        public DbSet<Player> Players { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<ResultGame> ResultGames { get; set; }
        public DbSet<Debut> Debuts { get; set; }
        public DbSet<GameType> GameTypes { get; set; }
    }
}
