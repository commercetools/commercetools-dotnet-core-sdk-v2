using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Api.Models.Projects.ProjectChangeCountriesAction))]
    public partial interface IProjectChangeCountriesAction : IProjectUpdateAction
    {
        List<string> Countries { get; set; }
    }
}
