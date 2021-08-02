using commercetools.HistoryApi.Models.Labels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Labels
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Labels.OrderLabel))]
    public partial interface IOrderLabel : ILabel
    {
        new string Type { get; set;}
        
        string CustomerEmail { get; set;}
        
        string OrderNumber { get; set;}
    }
}
