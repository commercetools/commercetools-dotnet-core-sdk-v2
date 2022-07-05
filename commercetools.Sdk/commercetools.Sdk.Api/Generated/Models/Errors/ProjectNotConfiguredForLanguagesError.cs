using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class ProjectNotConfiguredForLanguagesError : IProjectNotConfiguredForLanguagesError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public List<string> Languages { get; set; }
        public ProjectNotConfiguredForLanguagesError()
        {
            this.Code = "ProjectNotConfiguredForLanguages";
        }
    }
}
