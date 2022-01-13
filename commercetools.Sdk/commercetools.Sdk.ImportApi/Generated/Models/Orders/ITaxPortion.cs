using commercetools.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Orders.TaxPortion))]
    public partial interface ITaxPortion
    {
        string Name { get; set; }

        double Rate { get; set; }

        ITypedMoney Amount { get; set; }
    }
}
