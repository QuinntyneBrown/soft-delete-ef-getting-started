using SoftDeleteEntityFrameworkGettingStarted.Data.Helpers;

namespace SoftDeleteEntityFrameworkGettingStarted.Data.Model
{
    [SoftDelete("IsDeleted")]
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}
