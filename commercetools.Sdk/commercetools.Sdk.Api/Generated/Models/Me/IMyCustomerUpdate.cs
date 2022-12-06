using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCustomerUpdate))]
    public partial interface IMyCustomerUpdate
    {
        long Version { get; set; }

        IList<IMyCustomerUpdateAction> Actions { get; set; }
        IEnumerable<IMyCustomerUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
