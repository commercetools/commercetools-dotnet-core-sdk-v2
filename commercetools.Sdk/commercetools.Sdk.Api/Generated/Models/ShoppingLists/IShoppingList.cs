using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingList))]
    public partial interface IShoppingList : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        ICustomFields Custom { get; set; }

        ICustomerReference Customer { get; set; }

        long? DeleteDaysAfterLastModification { get; set; }

        ILocalizedString Description { get; set; }

        string Key { get; set; }

        List<IShoppingListLineItem> LineItems { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Slug { get; set; }

        List<ITextLineItem> TextLineItems { get; set; }

        string AnonymousId { get; set; }

        IStoreKeyReference Store { get; set; }
    }
}
