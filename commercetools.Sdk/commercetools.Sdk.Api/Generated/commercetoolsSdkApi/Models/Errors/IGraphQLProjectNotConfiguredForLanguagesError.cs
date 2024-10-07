using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLProjectNotConfiguredForLanguagesError))]
    public partial interface IGraphQLProjectNotConfiguredForLanguagesError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        IList<string> Languages { get; set; }

        IEnumerable<string> LanguagesEnumerable { set => Languages = value.ToList(); }

    }
}
