using System;


namespace commercetools.HistoryApi.Models.Common
{
    public partial class CustomFields : ICustomFields
    {
        public IReference Type { get; set; }

        public Object Fields { get; set; }
    }
}
