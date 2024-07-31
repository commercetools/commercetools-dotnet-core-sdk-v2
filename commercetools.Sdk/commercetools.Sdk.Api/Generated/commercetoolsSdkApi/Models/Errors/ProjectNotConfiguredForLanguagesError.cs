using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class ProjectNotConfiguredForLanguagesError : IProjectNotConfiguredForLanguagesError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public IList<string> Languages { get; set; }

        public IEnumerable<string> LanguagesEnumerable { set => Languages = value.ToList(); }
        public ProjectNotConfiguredForLanguagesError()
        {
            this.Code = "ProjectNotConfiguredForLanguages";
        }
    }
}
