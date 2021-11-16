using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Orders.TaxedPrice))]
    public partial interface ITaxedPrice 
    {
        IMoney TotalNet { get; set;}
        
        IMoney TotalGross { get; set;}
        
        List<ITaxPortion> TaxPortions { get; set;}
    }
}
