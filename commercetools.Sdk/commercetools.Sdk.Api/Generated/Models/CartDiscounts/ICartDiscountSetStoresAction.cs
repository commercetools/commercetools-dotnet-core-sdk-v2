using commercetools.Sdk.Api.Models.CartDiscounts;
using commercetools.Sdk.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetStoresAction))]
    public partial interface ICartDiscountSetStoresAction : ICartDiscountUpdateAction
    {
        IList<IStoreResourceIdentifier> Stores { get; set; }
        IEnumerable<IStoreResourceIdentifier> StoresEnumerable { set => Stores = value.ToList(); }


    }
}
