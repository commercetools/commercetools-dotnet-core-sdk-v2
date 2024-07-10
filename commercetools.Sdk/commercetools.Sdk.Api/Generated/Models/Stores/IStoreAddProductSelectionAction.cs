using commercetools.Sdk.Api.Models.ProductSelections;
using commercetools.Sdk.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreAddProductSelectionAction))]
    public partial interface IStoreAddProductSelectionAction : IStoreUpdateAction
    {
        IProductSelectionResourceIdentifier ProductSelection { get; set; }

        bool? Active { get; set; }

    }
}
