using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeChangeGroupsAction))]
    public partial interface IDiscountCodeChangeGroupsAction : IDiscountCodeUpdateAction
    {
        List<string> Groups { get; set;}
    }
}
