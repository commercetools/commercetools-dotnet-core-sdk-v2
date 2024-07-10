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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryUpdate))]
    public partial interface ITaxCategoryUpdate
    {
        long Version { get; set; }

        IList<ITaxCategoryUpdateAction> Actions { get; set; }
        IEnumerable<ITaxCategoryUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
