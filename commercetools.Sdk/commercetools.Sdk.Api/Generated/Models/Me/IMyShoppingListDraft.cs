using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShoppingLists;
using commercetools.Api.Models.Stores;
using commercetools.Api.Models.Types;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyShoppingListDraft))]
    public partial interface IMyShoppingListDraft 
    {
        ILocalizedString Name { get; set;}
        
        ILocalizedString Description { get; set;}
        
        List<IShoppingListLineItemDraft> LineItems { get; set;}
        
        List<ITextLineItemDraft> TextLineItems { get; set;}
        
        ICustomFieldsDraft Custom { get; set;}
        
        long? DeleteDaysAfterLastModification { get; set;}
        
        IStoreResourceIdentifier Store { get; set;}
    }
}
