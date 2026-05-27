using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Warnings
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Warnings.CannotUpdateReservationWarning))]
    public partial interface ICannotUpdateReservationWarning : IWarningObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        string LineItemId { get; set; }

        decimal RequestedQuantity { get; set; }

        decimal ReservedQuantity { get; set; }

        string ProductId { get; set; }

        string Sku { get; set; }

        string SupplyChannel { get; set; }

    }
}
