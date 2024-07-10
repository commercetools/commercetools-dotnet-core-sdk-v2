using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategory))]
    public partial interface ITaxCategory : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        string Name { get; set; }

        string Description { get; set; }

        IList<ITaxRate> Rates { get; set; }
        IEnumerable<ITaxRate> RatesEnumerable { set => Rates = value.ToList(); }


        string Key { get; set; }

    }
}
