using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.DiscountGroups
{

    public partial class DiscountGroupReference : IDiscountGroupReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IDiscountGroup Obj { get; set; }
        public DiscountGroupReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("discount-group");
        }
    }
}
