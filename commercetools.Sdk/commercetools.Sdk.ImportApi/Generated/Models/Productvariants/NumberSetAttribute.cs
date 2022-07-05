using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{

    public partial class NumberSetAttribute : INumberSetAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public List<decimal> Value { get; set; }
        public NumberSetAttribute()
        {
            this.Type = "number-set";
        }
    }
}
