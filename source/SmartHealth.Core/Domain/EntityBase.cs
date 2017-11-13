using System;
using System.ComponentModel.DataAnnotations;

namespace SmartHealth.Core.Domain
{
    public class EntityBase
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime Created { get; set; }
        public DateTime? LastModified { get; set; }
        public bool Enabled { get; set; }

        public bool IsNew()
        {
            return Id == Guid.Empty;
        }

        // TODO: optimise with caching
        public EntityBase()
        {
            var myType = this.GetType();
            var props = myType.GetProperties();
            var dateTimeType = typeof(DateTime);
            var nullableDateTimeType = typeof(DateTime?);
            var minDateValue = new DateTime(1900, 1, 1);
            foreach (var prop in props)
            {
                switch (prop.Name)
                {
                    case "Created":
                        break;
                    case "Enabled":
                        break;
                    default:
                        if (prop.PropertyType == dateTimeType)
                        {
                            var currentVal = (DateTime)prop.GetValue(this);
                            if (currentVal < minDateValue)
                                prop.SetValue(this, minDateValue);
                        }
                        else if (prop.PropertyType == nullableDateTimeType)
                        {
                            var currentVal = (DateTime?)prop.GetValue(this);
                            if (!currentVal.HasValue) continue;
                            if (currentVal.Value < minDateValue)
                                prop.SetValue(this, minDateValue);
                        }
                        break;
                }
            }

            this.Created = DateTime.Now;
            this.Enabled = true;
        }
    }
}