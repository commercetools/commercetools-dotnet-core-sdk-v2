using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCartAddDiscountCodeAction))]
    public partial interface IMyCartAddDiscountCodeAction : IMyCartUpdateAction
    {
        string Code { get; set;}
    }
}
