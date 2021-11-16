using System.Collections.Generic;


namespace commercetools.HistoryApi.Models.Common
{
    public partial class GeoLocation : IGeoLocation
    {
        public string Type { get; set;}
        
        public List<int> Coordinates { get; set;}
    }
}
