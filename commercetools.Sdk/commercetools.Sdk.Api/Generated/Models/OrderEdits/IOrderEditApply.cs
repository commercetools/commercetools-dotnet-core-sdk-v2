using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.OrderEditApply))]
    public partial interface IOrderEditApply
    {
        int EditVersion { get; set; }

        int ResourceVersion { get; set; }
    }
}
