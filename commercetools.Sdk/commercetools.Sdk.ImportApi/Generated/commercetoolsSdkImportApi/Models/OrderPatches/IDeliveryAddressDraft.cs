using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.OrderPatches
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.OrderPatches.DeliveryAddressDraft))]
    public partial interface IDeliveryAddressDraft
    {
        string DeliveryId { get; set; }

        IAddress Address { get; set; }

    }
}
