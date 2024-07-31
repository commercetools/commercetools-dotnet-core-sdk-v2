using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLProjectNotConfiguredForLanguagesError : IGraphQLProjectNotConfiguredForLanguagesError
    {
        public string Code { get; set; }

        public IList<string> Languages { get; set; }

        public IEnumerable<string> LanguagesEnumerable { set => Languages = value.ToList(); }
        public GraphQLProjectNotConfiguredForLanguagesError()
        {
            this.Code = "ProjectNotConfiguredForLanguages";
        }
    }
}
