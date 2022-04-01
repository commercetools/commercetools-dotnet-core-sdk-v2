using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeCountriesAction))]
    public partial interface IProjectChangeCountriesAction : IProjectUpdateAction
    {
        List<string> Countries { get; set; }
    }
}
