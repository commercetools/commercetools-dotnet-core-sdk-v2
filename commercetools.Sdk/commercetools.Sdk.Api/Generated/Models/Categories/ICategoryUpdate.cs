using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Categories.CategoryUpdate))]
    public partial interface ICategoryUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<ICategoryUpdate, ICategoryUpdateAction>
    {
        new long Version { get; set; }
        new IList<ICategoryUpdateAction> Actions { get; set; }
        IEnumerable<ICategoryUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
