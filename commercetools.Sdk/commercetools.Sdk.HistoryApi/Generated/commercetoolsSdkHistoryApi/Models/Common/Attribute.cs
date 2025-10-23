using System;

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class Attribute : IAttribute
    {
        public string Name { get; set; }

        public Object Value { get; set; }
    }
}
