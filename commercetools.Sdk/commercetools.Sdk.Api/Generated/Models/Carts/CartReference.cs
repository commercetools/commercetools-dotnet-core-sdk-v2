using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Carts
{
    public partial class CartReference : ICartReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public ICart Obj { get; set; }
        public CartReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("cart");
        }
    }
}
