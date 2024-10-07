

namespace commercetools.Sdk.ImportApi.Models.Productvariants
{

    public partial class BooleanAttribute : IBooleanAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public bool Value { get; set; }
        public BooleanAttribute()
        {
            this.Type = "boolean";
        }
    }
}
