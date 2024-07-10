using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLOutOfStockError))]
    public partial interface IGraphQLOutOfStockError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        IList<string> LineItems { get; set; }
        IEnumerable<string> LineItemsEnumerable { set => LineItems = value.ToList(); }


        IList<string> Skus { get; set; }
        IEnumerable<string> SkusEnumerable { set => Skus = value.ToList(); }


    }
}
