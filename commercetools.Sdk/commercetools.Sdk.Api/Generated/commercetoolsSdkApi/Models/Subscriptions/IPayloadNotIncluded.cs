using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.PayloadNotIncluded))]
    public partial interface IPayloadNotIncluded
    {
        string Reason { get; set; }

        string PayloadType { get; set; }

    }
}
