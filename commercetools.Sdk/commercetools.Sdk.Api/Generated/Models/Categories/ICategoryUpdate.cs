using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

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
