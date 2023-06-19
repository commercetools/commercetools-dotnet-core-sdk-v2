using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeUpdate))]
    public partial interface IDiscountCodeUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<IDiscountCodeUpdate, IDiscountCodeUpdateAction>
    {
        new long Version { get; set; }
        new IList<IDiscountCodeUpdateAction> Actions { get; set; }
        IEnumerable<IDiscountCodeUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
