using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.VerifyEmailChange))]
    public partial interface IVerifyEmailChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

    }
}
