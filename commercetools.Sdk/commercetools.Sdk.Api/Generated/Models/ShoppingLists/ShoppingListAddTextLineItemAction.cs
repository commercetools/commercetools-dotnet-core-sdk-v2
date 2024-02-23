using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{

    public partial class ShoppingListAddTextLineItemAction : IShoppingListAddTextLineItemAction
    {
        public string Action { get; set; }

        public ILocalizedString Name { get; set; }

        public string Key { get; set; }

        public ILocalizedString Description { get; set; }

        public long? Quantity { get; set; }

        public DateTime? AddedAt { get; set; }

        public ICustomFieldsDraft Custom { get; set; }
        public ShoppingListAddTextLineItemAction()
        {
            this.Action = "addTextLineItem";
        }
    }
}
