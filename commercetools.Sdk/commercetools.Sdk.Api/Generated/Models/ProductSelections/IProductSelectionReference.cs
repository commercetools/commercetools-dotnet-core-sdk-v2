using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionReference))]
    public partial interface IProductSelectionReference : IReference
    {
        new string Id { get; set; }

        IProductSelection Obj { get; set; }

    }
}
