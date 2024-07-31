using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.CustomFields))]
    public partial interface ICustomFields
    {
        ITypeReference Type { get; set; }

        IFieldContainer Fields { get; set; }

    }
}
