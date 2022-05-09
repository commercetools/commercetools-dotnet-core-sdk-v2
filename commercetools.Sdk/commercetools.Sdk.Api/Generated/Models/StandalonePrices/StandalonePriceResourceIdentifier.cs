using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.StandalonePrices
{
    public partial class StandalonePriceResourceIdentifier : IStandalonePriceResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public StandalonePriceResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("standalone-price");
        }
    }
}
