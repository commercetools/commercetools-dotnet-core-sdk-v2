using System;

namespace commercetools.Sdk.ImportApi.Models.Productvariants
{

    public partial class TimeAttribute : ITimeAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public TimeSpan Value { get; set; }
        public TimeAttribute()
        {
            this.Type = "time";
        }
    }
}
