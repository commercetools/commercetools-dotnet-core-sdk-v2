using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.ParcelMeasurements))]
    public partial interface IParcelMeasurements 
    {
        int HeightInMillimeter { get; set;}
        
        int LengthInMillimeter { get; set;}
        
        int WidthInMillimeter { get; set;}
        
        int WeightInGram { get; set;}
    }
}