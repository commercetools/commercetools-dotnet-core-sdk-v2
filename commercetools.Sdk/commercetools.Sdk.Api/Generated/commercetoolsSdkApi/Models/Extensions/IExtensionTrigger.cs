using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionTrigger))]
    public partial interface IExtensionTrigger
    {
        IExtensionResourceTypeId ResourceTypeId { get; set; }

        IList<IExtensionAction> Actions { get; set; }

        IEnumerable<IExtensionAction> ActionsEnumerable { set => Actions = value.ToList(); }

        string Condition { get; set; }

    }
}
