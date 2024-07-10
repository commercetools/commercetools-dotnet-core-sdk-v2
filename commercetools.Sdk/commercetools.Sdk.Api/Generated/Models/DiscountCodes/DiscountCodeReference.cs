using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{

    public partial class DiscountCodeReference : IDiscountCodeReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IDiscountCode Obj { get; set; }
        public DiscountCodeReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("discount-code");
        }
    }
}
