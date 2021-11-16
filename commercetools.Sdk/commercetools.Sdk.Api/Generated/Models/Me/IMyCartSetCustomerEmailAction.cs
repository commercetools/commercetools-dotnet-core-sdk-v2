using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCartSetCustomerEmailAction))]
    public partial interface IMyCartSetCustomerEmailAction : IMyCartUpdateAction
    {
        string Email { get; set;}
    }
}
