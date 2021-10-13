using commercetools.Api.Models.Common;

namespace commercetools.Api.Models.Products
{
    public class LocalizedStringAttribute : Attribute, GenericAttribute<LocalizedString>
    {
        public LocalizedString GetValue() => (LocalizedString)Value;
    }
}