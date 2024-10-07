using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Categories.CategoryReference))]
    public partial interface ICategoryReference : IReference
    {
        ICategory Obj { get; set; }

        new string Id { get; set; }

    }
}
