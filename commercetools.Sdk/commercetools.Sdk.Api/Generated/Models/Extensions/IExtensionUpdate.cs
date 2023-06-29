using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionUpdate))]
    public partial interface IExtensionUpdate
    {
        new long Version { get; set; }
        new IList<IExtensionUpdateAction> Actions { get; set; }
        IEnumerable<IExtensionUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
