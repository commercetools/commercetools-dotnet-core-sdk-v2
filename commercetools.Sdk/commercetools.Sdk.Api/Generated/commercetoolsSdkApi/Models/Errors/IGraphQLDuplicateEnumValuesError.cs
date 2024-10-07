using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateEnumValuesError))]
    public partial interface IGraphQLDuplicateEnumValuesError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        IList<string> Duplicates { get; set; }

        IEnumerable<string> DuplicatesEnumerable { set => Duplicates = value.ToList(); }

    }
}
