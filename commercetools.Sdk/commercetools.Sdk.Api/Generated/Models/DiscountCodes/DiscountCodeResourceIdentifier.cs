using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    public partial class DiscountCodeResourceIdentifier : IDiscountCodeResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public DiscountCodeResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("discount-code");
        }
    }
}
