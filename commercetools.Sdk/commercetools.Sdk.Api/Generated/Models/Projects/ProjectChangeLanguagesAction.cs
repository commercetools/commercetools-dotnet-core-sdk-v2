using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class ProjectChangeLanguagesAction : IProjectChangeLanguagesAction
    {
        public string Action { get; set; }

        public IList<string> Languages { get; set; }
        public IEnumerable<string> LanguagesEnumerable { set => Languages = value.ToList(); }

        public ProjectChangeLanguagesAction()
        {
            this.Action = "changeLanguages";
        }
    }
}
