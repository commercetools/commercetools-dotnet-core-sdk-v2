namespace commercetools.ImportApi.Models.Common
{
    public partial class PriceKeyReference : IPriceKeyReference
    {
        public string Key { get; set; }

        public IReferenceType TypeId { get; set; }
        public PriceKeyReference()
        {
            this.TypeId = IReferenceType.FindEnum("price");
        }
    }
}
