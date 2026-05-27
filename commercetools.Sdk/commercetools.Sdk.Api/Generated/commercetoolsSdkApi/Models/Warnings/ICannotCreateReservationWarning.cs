using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Warnings
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Warnings.CannotCreateReservationWarning))]
    public partial interface ICannotCreateReservationWarning : IWarningObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        string ProductId { get; set; }

        string Sku { get; set; }

        string SupplyChannel { get; set; }

        decimal Quantity { get; set; }

    }
}
