using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Productvariants
{
    public partial class NumberSetAttribute : INumberSetAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public List<double> Value { get; set; }
        public NumberSetAttribute()
        {
            this.Type = "number-set";
        }
    }
}
