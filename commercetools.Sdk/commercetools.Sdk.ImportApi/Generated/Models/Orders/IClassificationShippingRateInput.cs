using commercetools.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Orders.ClassificationShippingRateInput))]
    public partial interface IClassificationShippingRateInput : IShippingRateInput
    {
        string Key { get; set;}
        
        ILocalizedString Label { get; set;}
    }
}
