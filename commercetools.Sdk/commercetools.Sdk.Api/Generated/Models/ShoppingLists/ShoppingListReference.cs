using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.ShoppingLists
{
    public partial class ShoppingListReference : IShoppingListReference
    {
        public IReferenceTypeId TypeId { get; set;}
        
        public string Id { get; set;}
        
        public IShoppingList Obj { get; set;}
        public ShoppingListReference()
        { 
           this.TypeId = IReferenceTypeId.FindEnum("shopping-list");
        }
    }
}
