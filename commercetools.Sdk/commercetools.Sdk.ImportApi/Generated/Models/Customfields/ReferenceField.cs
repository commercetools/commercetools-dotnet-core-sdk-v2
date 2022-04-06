using commercetools.Sdk.ImportApi.Models.Common;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    public partial class ReferenceField : IReferenceField
    {
        public string Type { get; set; }

        public IKeyReference Value { get; set; }
        public ReferenceField()
        {
            this.Type = "Reference";
        }
    }
}
