using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ParcelMeasurements))]
    public partial interface IParcelMeasurements
    {
        int HeightInMillimeter { get; set; }

        int LengthInMillimeter { get; set; }

        int WidthInMillimeter { get; set; }

        int WeightInGram { get; set; }
    }
}
