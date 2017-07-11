using System;

namespace SmartHealth.Core
{
    interface IDateTimeProvider
    {
        DateTime Now { get; }
        DateTime Today { get; }
    }
}
