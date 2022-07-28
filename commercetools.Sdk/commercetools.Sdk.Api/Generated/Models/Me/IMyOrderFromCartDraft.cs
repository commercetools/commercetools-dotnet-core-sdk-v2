using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyOrderFromCartDraft))]
    public partial interface IMyOrderFromCartDraft
    {
        string Id { get; set; }

        long Version { get; set; }

    }
}
