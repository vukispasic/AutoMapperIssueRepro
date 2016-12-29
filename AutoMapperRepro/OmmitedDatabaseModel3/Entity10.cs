using System.Collections.Generic;

namespace OmmitedDatabaseModel3
{
    public class Entity10 : BaseEntity
    {
        public Entity10()
        {
            this.Entities11 = new List<Entity11>();
        }
        public ICollection<Entity11> Entities11 { get; set; }
    }
}
