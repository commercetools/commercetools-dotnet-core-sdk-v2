namespace commercetools.ImportApi.Models.Customfields
{
    public partial class NumberField : INumberField
    {
        public string Type { get; set; }

        public double Value { get; set; }
        public NumberField()
        {
            this.Type = "Number";
        }
    }
}
