using System;


namespace commercetools.ImportApi.Models.Customfields
{
    public partial class TimeField : ITimeField
    {
        public string Type { get; set; }

        public TimeSpan Value { get; set; }
        public TimeField()
        {
            this.Type = "Time";
        }
    }
}
