using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetPasswordChange))]
    public partial interface ISetPasswordChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

    }
}
