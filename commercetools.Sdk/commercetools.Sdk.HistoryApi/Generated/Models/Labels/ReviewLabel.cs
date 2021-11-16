using commercetools.HistoryApi.Models.Labels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Labels
{
    public partial class ReviewLabel : IReviewLabel
    {
        public string Type { get; set;}
        
        public string Key { get; set;}
        
        public string Title { get; set;}
        public ReviewLabel()
        { 
           this.Type = "ReviewLabel";
        }
    }
}
