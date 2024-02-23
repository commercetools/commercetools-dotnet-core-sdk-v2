using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ReturnInfoSetMessage))]
    public partial interface IReturnInfoSetMessage : IOrderMessage
    {
        IList<IReturnInfo> ReturnInfo { get; set; }
        IEnumerable<IReturnInfo> ReturnInfoEnumerable { set => ReturnInfo = value.ToList(); }


    }
}
