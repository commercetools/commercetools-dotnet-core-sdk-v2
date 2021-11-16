using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShoppingLists;
using commercetools.Api.Models.Stores;
using commercetools.Api.Models.Types;
using System.Collections.Generic;


namespace commercetools.Api.Models.Me
{
    public partial class MyShoppingListDraft : IMyShoppingListDraft
    {
        public ILocalizedString Name { get; set;}
        
        public ILocalizedString Description { get; set;}
        
        public List<IShoppingListLineItemDraft> LineItems { get; set;}
        
        public List<ITextLineItemDraft> TextLineItems { get; set;}
        
        public ICustomFieldsDraft Custom { get; set;}
        
        public long? DeleteDaysAfterLastModification { get; set;}
        
        public IStoreResourceIdentifier Store { get; set;}
    }
}
