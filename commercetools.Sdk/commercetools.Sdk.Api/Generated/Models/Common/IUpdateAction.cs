using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.UpdateAction))]
    public partial interface IUpdateAction
    {
        string Action { get; set; }
    }
}
