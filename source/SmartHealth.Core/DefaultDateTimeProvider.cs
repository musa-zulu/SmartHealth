using System;

namespace SmartHealth.Core
{
    public class DefaultDateTimeProvider : IDateTimeProvider
    {
        public DateTime Now => DateTime.Now;
        public DateTime Today => DateTime.Today;
    }
}
