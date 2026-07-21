using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLUnauthorizedError))]
    public partial interface IGraphQLUnauthorizedError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        IList<string> StoresWithoutPermission { get; set; }

        IEnumerable<string> StoresWithoutPermissionEnumerable { set => StoresWithoutPermission = value.ToList(); }

    }
}
