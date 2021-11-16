using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Api.Models.Common.UpdateAction))]
    public partial interface IUpdateAction
    {
        string Action { get; set; }
    }
}
