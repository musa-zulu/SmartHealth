using System.Collections.Generic;

namespace SmartHealth.Core.Domain
{
    public class Title : EntityBase
    {
        public Title()
        {
            People = new List<Person>();
        }

        public string Description { get; set; }
        public virtual ICollection<Person> People { get; set; }
    }
}