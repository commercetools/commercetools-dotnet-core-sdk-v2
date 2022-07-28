using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetValidFromAndUntilChange))]
    public partial interface ISetValidFromAndUntilChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IValidFromAndUntilValue PreviousValue { get; set; }

        IValidFromAndUntilValue NextValue { get; set; }

    }
}
