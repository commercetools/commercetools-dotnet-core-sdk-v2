using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectUpdate))]
    public partial interface IProjectUpdate
    {
        long Version { get; set; }

        List<IProjectUpdateAction> Actions { get; set; }
    }
}
