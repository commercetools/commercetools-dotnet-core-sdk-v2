using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    public partial class ParcelMeasurements : IParcelMeasurements
    {
        public int HeightInMillimeter { get; set;}
        
        public int LengthInMillimeter { get; set;}
        
        public int WidthInMillimeter { get; set;}
        
        public int WeightInGram { get; set;}
    }
}
