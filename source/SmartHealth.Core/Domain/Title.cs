using System.Collections.Generic;

namespace SmartHealth.Core.Domain
{
    public sealed class Title : EntityBase
    {
        public Title()
        {
            People = new List<Person>();
        }

        public string Description { get; set; }
        public ICollection<Person> People { get; set; }
    }
}