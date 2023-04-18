using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class DirectDiscountReference : IDirectDiscountReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public DirectDiscountReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("direct-discount");
        }
    }
}
