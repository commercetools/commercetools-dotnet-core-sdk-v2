using commercetools.Sdk.Api.Models.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Categories.CategoryUpdate))]
    public partial interface ICategoryUpdate
    {
        long Version { get; set; }

        IList<ICategoryUpdateAction> Actions { get; set; }
        IEnumerable<ICategoryUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
