using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Common.DiscountedPrice))]
    public partial interface IDiscountedPrice 
    {
        ITypedMoney Value { get; set;}
        
        IProductDiscountKeyReference Discount { get; set;}
    }
}
