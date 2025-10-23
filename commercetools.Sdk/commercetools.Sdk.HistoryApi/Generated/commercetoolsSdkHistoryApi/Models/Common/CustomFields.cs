

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class CustomFields : ICustomFields
    {
        public ITypeReference Type { get; set; }

        public IFieldContainer Fields { get; set; }
    }
}
