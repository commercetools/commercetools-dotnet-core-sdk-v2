using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectUpdate))]
    public partial interface IProjectUpdate
    {
        long Version { get; set; }

        IList<IProjectUpdateAction> Actions { get; set; }

        IEnumerable<IProjectUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
