using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartUpdate))]
    public partial interface ICartUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<ICartUpdate, ICartUpdateAction>
    {
        new long Version { get; set; }
        new IList<ICartUpdateAction> Actions { get; set; }
        IEnumerable<ICartUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
