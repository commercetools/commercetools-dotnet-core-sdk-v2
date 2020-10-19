using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Orders
{
    public partial class ParcelMeasurements 
    {
        public double HeightInMillimeter { get; set;}
        
        public double LengthInMillimeter { get; set;}
        
        public double WidthInMillimeter { get; set;}
        
        public double WeightInGram { get; set;}
    }
}
