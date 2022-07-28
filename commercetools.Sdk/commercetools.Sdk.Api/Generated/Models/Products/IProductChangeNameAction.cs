using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductChangeNameAction))]
    public partial interface IProductChangeNameAction : IProductUpdateAction
    {
        ILocalizedString Name { get; set; }

        bool? Staged { get; set; }

    }
}
