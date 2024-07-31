

namespace commercetools.Sdk.Api.Models.Types
{

    public partial class CustomFieldsDraft : ICustomFieldsDraft
    {
        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
    }
}
