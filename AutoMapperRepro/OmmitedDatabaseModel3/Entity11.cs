using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmmitedDatabaseModel3
{
    public class Entity11 : BaseEntity
    {
        public Entity11()
        {
            this.Entities10 = new List<Entity10>();
            this.Entities8 = new List<Entity8>();
        }
        public ICollection<Entity10> Entities10 { get; set; }
        public ICollection<Entity8> Entities8 { get; set; }
    }
}
