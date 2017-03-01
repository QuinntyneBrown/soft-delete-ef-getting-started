using System.Data.Entity.Migrations;
using SoftDeleteEntityFrameworkGettingStarted.Data;
using System.Data.Entity.Migrations;
using SoftDeleteEntityFrameworkGettingStarted.Data.Model;
using System.Collections.Generic;

namespace SoftDeleteEntityFrameworkGettingStarted.Migrations
{
    public class GameConfiguration
    {
        public static void Seed(DataContext context) {

            context.Games.AddOrUpdate(g => g.Name, new Game() { Name = "Snake", IsDeleted = true });

            context.Games.AddOrUpdate(g => g.Name, new Game() { Name = "Tetris", IsDeleted = false });

            context.SaveChanges();
        }
    }
}
