using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditApply))]
    public partial interface IOrderEditApply
    {
        long EditVersion { get; set; }

        long ResourceVersion { get; set; }

    }
}
