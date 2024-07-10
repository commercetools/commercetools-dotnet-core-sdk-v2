using commercetools.Sdk.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


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
