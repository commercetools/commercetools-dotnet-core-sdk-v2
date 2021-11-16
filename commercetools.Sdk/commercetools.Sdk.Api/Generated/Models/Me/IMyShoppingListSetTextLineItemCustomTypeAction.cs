using commercetools.Api.Models.Types;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyShoppingListSetTextLineItemCustomTypeAction))]
    public partial interface IMyShoppingListSetTextLineItemCustomTypeAction : IMyShoppingListUpdateAction
    {
        string TextLineItemId { get; set;}
        
        ITypeResourceIdentifier Type { get; set;}
        
        IFieldContainer Fields { get; set;}
    }
}
