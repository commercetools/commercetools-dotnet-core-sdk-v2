using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditApply))]
    public partial interface IOrderEditApply
    {
        int EditVersion { get; set; }

        int ResourceVersion { get; set; }
    }
}
