using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangeLabelAction))]
    public partial interface IProductTypeChangeLabelAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set; }

        ILocalizedString Label { get; set; }
    }
}
