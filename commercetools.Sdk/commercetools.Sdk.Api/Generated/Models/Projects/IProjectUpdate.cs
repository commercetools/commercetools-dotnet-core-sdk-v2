using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Api.Models.Projects.ProjectUpdate))]
    public partial interface IProjectUpdate 
    {
        long Version { get; set;}
        
        List<IProjectUpdateAction> Actions { get; set;}
    }
}
