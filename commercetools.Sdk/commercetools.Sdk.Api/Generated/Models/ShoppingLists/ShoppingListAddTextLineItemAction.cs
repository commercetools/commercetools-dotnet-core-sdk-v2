using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;


namespace commercetools.Api.Models.ShoppingLists
{
    public partial class ShoppingListAddTextLineItemAction : IShoppingListAddTextLineItemAction
    {
        public string Action { get; set; }

        public ILocalizedString Name { get; set; }

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
