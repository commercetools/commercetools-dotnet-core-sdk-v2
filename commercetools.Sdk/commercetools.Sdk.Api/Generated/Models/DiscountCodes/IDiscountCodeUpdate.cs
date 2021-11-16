using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeUpdate))]
    public partial interface IDiscountCodeUpdate 
    {
        long Version { get; set;}
        
        List<IDiscountCodeUpdateAction> Actions { get; set;}
    }
}
