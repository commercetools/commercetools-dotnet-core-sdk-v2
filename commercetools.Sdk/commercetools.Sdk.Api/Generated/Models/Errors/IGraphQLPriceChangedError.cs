using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLPriceChangedError))]
    public partial interface IGraphQLPriceChangedError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        IList<string> LineItems { get; set; }
        IEnumerable<string> LineItemsEnumerable { set => LineItems = value.ToList(); }


        bool Shipping { get; set; }

    }
}
