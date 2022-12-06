using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.OutOfStockError))]
    public partial interface IOutOfStockError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        IList<string> LineItems { get; set; }
        IEnumerable<string> LineItemsEnumerable { set => LineItems = value.ToList(); }


        IList<string> Skus { get; set; }
        IEnumerable<string> SkusEnumerable { set => Skus = value.ToList(); }


    }
}
