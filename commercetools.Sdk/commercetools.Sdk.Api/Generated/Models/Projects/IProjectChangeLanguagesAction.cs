using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Api.Models.Projects.ProjectChangeLanguagesAction))]
    public partial interface IProjectChangeLanguagesAction : IProjectUpdateAction
    {
        List<string> Languages { get; set;}
    }
}
