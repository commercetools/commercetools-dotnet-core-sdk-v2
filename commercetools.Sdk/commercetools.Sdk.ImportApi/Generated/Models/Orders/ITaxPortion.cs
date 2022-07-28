using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.TaxPortion))]
    public partial interface ITaxPortion
    {
        string Name { get; set; }

        decimal Rate { get; set; }

        ITypedMoney Amount { get; set; }

    }
}
