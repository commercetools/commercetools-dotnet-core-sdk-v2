using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartAddDiscountCodeAction))]
    public partial interface IMyCartAddDiscountCodeAction : IMyCartUpdateAction
    {
        string Code { get; set; }

    }
}
