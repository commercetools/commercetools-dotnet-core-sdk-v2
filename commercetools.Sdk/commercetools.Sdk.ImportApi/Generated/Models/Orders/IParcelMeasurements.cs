using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Orders.ParcelMeasurements))]
    public partial interface IParcelMeasurements 
    {
        double? HeightInMillimeter { get; set;}
        
        double? LengthInMillimeter { get; set;}
        
        double? WidthInMillimeter { get; set;}
        
        double? WeightInGram { get; set;}
    }
}
