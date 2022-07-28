using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectUpdate))]
    public partial interface IProjectUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<IProjectUpdate, IProjectUpdateAction>
    {
        new long Version { get; set; }
        new List<IProjectUpdateAction> Actions { get; set; }

    }
}
