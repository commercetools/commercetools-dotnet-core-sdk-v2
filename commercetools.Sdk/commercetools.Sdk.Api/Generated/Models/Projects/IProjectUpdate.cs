using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectUpdate))]
    public partial interface IProjectUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<IProjectUpdate, IProjectUpdateAction>
    {
        new long Version { get; set; }
        new IList<IProjectUpdateAction> Actions { get; set; }
        IEnumerable<IProjectUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
