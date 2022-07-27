using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditApply))]
    public partial interface IOrderEditApply
    {
        long EditVersion { get; set; }

        long ResourceVersion { get; set; }
    }
}
