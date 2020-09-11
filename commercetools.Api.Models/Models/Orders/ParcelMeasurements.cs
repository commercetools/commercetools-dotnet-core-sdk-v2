using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Orders
{
    public class ParcelMeasurements 
    {
        public double HeightInMillimeter { get; set;}
        
        public double LengthInMillimeter { get; set;}
        
        public double WidthInMillimeter { get; set;}
        
        public double WeightInGram { get; set;}
    }
}
