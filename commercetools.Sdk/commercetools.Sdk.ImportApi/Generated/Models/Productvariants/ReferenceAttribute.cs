using commercetools.Sdk.ImportApi.Models.Common;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    public partial class ReferenceAttribute : IReferenceAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public IKeyReference Value { get; set; }
        public ReferenceAttribute()
        {
            this.Type = "reference";
        }
    }
}
