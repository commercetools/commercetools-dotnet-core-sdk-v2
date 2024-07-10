using commercetools.Sdk.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

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
