using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.DateAttribute))]
    public partial interface IDateAttribute : IAttribute
    {
        Date Value { get; set; }

    }
}
