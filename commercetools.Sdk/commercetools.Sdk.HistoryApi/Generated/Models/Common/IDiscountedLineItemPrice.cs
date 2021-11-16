using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.DiscountedLineItemPrice))]
    public partial interface IDiscountedLineItemPrice 
    {
        IMoney Value { get; set;}
        
        List<IDiscountedLineItemPortion> IncludedDiscounts { get; set;}
    }
}
