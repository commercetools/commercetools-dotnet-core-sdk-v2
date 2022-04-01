using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeSetInputTipAction))]
    public partial interface IProductTypeSetInputTipAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set; }

        ILocalizedString InputTip { get; set; }
    }
}
