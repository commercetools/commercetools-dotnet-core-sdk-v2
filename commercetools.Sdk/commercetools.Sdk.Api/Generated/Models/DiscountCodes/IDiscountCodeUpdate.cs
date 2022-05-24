using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeUpdate))]
    public partial interface IDiscountCodeUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<IDiscountCodeUpdate, IDiscountCodeUpdateAction>
    {
        new long Version { get; set; }
        new List<IDiscountCodeUpdateAction> Actions { get; set; }
    }
}
