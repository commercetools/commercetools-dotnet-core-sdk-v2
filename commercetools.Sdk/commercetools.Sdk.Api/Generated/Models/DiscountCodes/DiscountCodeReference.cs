using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.DiscountCodes
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
