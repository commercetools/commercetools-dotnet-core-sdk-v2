using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{

    public partial class BooleanSetAttribute : IBooleanSetAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public List<bool> Value { get; set; }
        public BooleanSetAttribute()
        {
            this.Type = "boolean-set";
        }
    }
}
