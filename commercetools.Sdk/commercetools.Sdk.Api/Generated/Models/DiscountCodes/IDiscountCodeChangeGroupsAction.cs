using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeChangeGroupsAction))]
    public partial interface IDiscountCodeChangeGroupsAction : IDiscountCodeUpdateAction
    {
        List<string> Groups { get; set; }
    }
}
