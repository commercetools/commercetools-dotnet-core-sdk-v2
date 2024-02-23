using System;


namespace commercetools.Sdk.ImportApi.Models.Customfields
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
