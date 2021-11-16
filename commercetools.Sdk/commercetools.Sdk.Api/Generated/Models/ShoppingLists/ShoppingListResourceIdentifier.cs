using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.ShoppingLists
{
    public partial class ShoppingListResourceIdentifier : IShoppingListResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public ShoppingListResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("shopping-list");
        }
    }
}
