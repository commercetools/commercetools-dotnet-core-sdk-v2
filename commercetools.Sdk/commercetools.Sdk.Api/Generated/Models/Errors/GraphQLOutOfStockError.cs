using commercetools.Sdk.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLOutOfStockError : IGraphQLOutOfStockError
    {
        public string Code { get; set; }

        public IList<string> LineItems { get; set; }
        public IEnumerable<string> LineItemsEnumerable { set => LineItems = value.ToList(); }


        public IList<string> Skus { get; set; }
        public IEnumerable<string> SkusEnumerable { set => Skus = value.ToList(); }

        public GraphQLOutOfStockError()
        {
            this.Code = "OutOfStock";
        }
    }
}
