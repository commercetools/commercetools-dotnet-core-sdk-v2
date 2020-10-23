using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Orders
{
    public interface IParcelMeasurements 
    {
        double HeightInMillimeter { get; set;}
        
        double LengthInMillimeter { get; set;}
        
        double WidthInMillimeter { get; set;}
        
        double WeightInGram { get; set;}
    }
}
