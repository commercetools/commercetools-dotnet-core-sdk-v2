using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyShoppingListSetTextLineItemDescriptionAction))]
    public partial interface IMyShoppingListSetTextLineItemDescriptionAction : IMyShoppingListUpdateAction
    {
        string TextLineItemId { get; set;}
        
        ILocalizedString Description { get; set;}
    }
}
