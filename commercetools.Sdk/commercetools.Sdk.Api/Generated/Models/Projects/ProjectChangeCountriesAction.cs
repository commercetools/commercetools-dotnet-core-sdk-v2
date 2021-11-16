using System.Collections.Generic;


namespace commercetools.Api.Models.Projects
{
    public partial class ProjectChangeCountriesAction : IProjectChangeCountriesAction
    {
        public string Action { get; set; }

        public List<string> Countries { get; set; }
        public ProjectChangeCountriesAction()
        {
            this.Action = "changeCountries";
        }
    }
}
