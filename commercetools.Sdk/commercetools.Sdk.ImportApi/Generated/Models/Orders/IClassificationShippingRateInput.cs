using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.ClassificationShippingRateInput))]
    public partial interface IClassificationShippingRateInput : IShippingRateInput
    {
        string Key { get; set; }

        ILocalizedString Label { get; set; }
    }
}
