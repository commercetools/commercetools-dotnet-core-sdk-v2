namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    public partial class NumberAttribute : INumberAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public decimal Value { get; set; }
        public NumberAttribute()
        {
            this.Type = "number";
        }
    }
}
