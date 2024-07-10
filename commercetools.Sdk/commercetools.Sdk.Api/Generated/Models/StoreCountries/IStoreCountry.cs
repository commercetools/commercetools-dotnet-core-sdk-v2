using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.StoreCountries
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StoreCountries.StoreCountry))]
    public partial interface IStoreCountry
    {
        string Code { get; set; }

    }
}
