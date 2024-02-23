using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryReference))]
    public partial interface ITaxCategoryReference : IReference
    {
        ITaxCategory Obj { get; set; }

        new string Id { get; set; }

    }
}
