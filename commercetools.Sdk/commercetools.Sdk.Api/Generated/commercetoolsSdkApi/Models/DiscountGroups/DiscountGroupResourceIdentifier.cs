using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.DiscountGroups
{

    public partial class DiscountGroupResourceIdentifier : IDiscountGroupResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public DiscountGroupResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("discount-group");
        }
    }
}
