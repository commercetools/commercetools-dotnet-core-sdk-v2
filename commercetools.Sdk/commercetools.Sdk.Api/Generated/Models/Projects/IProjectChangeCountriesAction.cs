using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeCountriesAction))]
    public partial interface IProjectChangeCountriesAction : IProjectUpdateAction
    {
        IList<string> Countries { get; set; }
        IEnumerable<string> CountriesEnumerable { set => Countries = value.ToList(); }


    }
}
