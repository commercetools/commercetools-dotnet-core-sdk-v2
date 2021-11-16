using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeSetCustomFieldAction))]
    public partial interface IDiscountCodeSetCustomFieldAction : IDiscountCodeUpdateAction
    {
        string Name { get; set;}
        
        Object Value { get; set;}
    }
}
