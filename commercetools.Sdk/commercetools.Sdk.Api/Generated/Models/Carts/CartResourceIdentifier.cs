using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartResourceIdentifier : ICartResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public CartResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("cart");
        }

        public CartResourceIdentifier(string id) : this()
        {
            Id = id;
        }
    }
}
