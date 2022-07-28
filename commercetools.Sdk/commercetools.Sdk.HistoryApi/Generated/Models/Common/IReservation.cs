using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.Reservation))]
    public partial interface IReservation
    {
        int Quantity { get; set; }

        IReference Owner { get; set; }

        string CreatedAt { get; set; }

        string CheckoutStartedAt { get; set; }

    }
}
