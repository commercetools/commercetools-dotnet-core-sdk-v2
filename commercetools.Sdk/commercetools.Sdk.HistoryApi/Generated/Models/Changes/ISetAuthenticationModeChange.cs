using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetAuthenticationModeChange))]
    public partial interface ISetAuthenticationModeChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IAuthenticationMode PreviousValue { get; set; }

        IAuthenticationMode NextValue { get; set; }

    }
}
