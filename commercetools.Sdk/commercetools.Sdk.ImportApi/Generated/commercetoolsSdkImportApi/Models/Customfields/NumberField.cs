

namespace commercetools.Sdk.ImportApi.Models.Customfields
{

    public partial class NumberField : INumberField
    {
        public string Type { get; set; }

        public decimal Value { get; set; }
        public NumberField()
        {
            this.Type = "Number";
        }
    }
}
