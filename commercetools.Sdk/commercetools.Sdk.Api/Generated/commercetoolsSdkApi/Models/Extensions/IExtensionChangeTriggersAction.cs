using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionChangeTriggersAction))]
    public partial interface IExtensionChangeTriggersAction : IExtensionUpdateAction
    {
        IList<IExtensionTrigger> Triggers { get; set; }

        IEnumerable<IExtensionTrigger> TriggersEnumerable { set => Triggers = value.ToList(); }

    }
}
