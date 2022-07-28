using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Categories.CategoryUpdate))]
    public partial interface ICategoryUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<ICategoryUpdate, ICategoryUpdateAction>
    {
        new long Version { get; set; }
        new List<ICategoryUpdateAction> Actions { get; set; }

    }
}
