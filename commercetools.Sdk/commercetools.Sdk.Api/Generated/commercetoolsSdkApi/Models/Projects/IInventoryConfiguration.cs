using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.InventoryConfiguration))]
    public partial interface IInventoryConfiguration
    {
        int? ReservationExpirationInMinutes { get; set; }

        bool ReleaseExpiredReservations { get; set; }

    }
}
