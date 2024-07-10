using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.StandalonePrices
{

    public partial class StandalonePriceReference : IStandalonePriceReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IStandalonePrice Obj { get; set; }
        public StandalonePriceReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("standalone-price");
        }
    }
}
