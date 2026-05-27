using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Warnings
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Warnings.CannotChangeReservationExpiryWarning))]
    public partial interface ICannotChangeReservationExpiryWarning : IWarningObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        string LineItemId { get; set; }

    }
}
