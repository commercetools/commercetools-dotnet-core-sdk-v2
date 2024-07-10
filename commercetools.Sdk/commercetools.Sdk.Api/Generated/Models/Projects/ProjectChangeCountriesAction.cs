using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class ProjectChangeCountriesAction : IProjectChangeCountriesAction
    {
        public string Action { get; set; }

        public IList<string> Countries { get; set; }
        public IEnumerable<string> CountriesEnumerable { set => Countries = value.ToList(); }

        public ProjectChangeCountriesAction()
        {
            this.Action = "changeCountries";
        }
    }
}
