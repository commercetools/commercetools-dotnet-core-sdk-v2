using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class ProjectChangeLanguagesAction : IProjectChangeLanguagesAction
    {
        public string Action { get; set; }

        public List<string> Languages { get; set; }
        public ProjectChangeLanguagesAction()
        {
            this.Action = "changeLanguages";
        }
    }
}
