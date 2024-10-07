using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTailorings
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetNameAction))]
    public partial interface IProductTailoringSetNameAction : IProductTailoringUpdateAction
    {
        ILocalizedString Name { get; set; }

        bool? Staged { get; set; }

    }
}
