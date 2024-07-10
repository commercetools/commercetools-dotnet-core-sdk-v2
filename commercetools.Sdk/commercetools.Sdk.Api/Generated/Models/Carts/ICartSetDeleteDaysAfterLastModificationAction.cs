using commercetools.Sdk.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetDeleteDaysAfterLastModificationAction))]
    public partial interface ICartSetDeleteDaysAfterLastModificationAction : ICartUpdateAction
    {
        int? DeleteDaysAfterLastModification { get; set; }

    }
}
