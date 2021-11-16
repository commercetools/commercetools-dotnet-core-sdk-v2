using System.Collections.Generic;


namespace commercetools.Api.Models.Errors
{
    public partial class OutOfStockError : IOutOfStockError
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
        
        public List<string> LineItems { get; set;}
        
        public List<string> Skus { get; set;}
        public OutOfStockError()
        { 
           this.Code = "OutOfStock";
        }
    }
}
