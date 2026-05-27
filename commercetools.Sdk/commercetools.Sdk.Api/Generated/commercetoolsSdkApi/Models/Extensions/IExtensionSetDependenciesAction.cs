using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionSetDependenciesAction))]
    public partial interface IExtensionSetDependenciesAction : IExtensionUpdateAction
    {
        IList<IExtensionResourceIdentifier> Dependencies { get; set; }

        IEnumerable<IExtensionResourceIdentifier> DependenciesEnumerable { set => Dependencies = value.ToList(); }

    }
}
