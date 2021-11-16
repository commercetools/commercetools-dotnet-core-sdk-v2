using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.OutOfStockError))]
    public partial interface IOutOfStockError : IErrorObject
    {
        List<string> LineItems { get; set;}
        
        List<string> Skus { get; set;}
    }
}
