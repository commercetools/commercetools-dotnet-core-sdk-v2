using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.TaxPortion))]
    public partial interface ITaxPortion 
    {
        string Name { get; set;}
        
        double Rate { get; set;}
        
        ITypedMoney Amount { get; set;}
    }
}
