using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCustomerSetMiddleNameAction))]
    public partial interface IMyCustomerSetMiddleNameAction : IMyCustomerUpdateAction
    {
        string MiddleName { get; set; }
    }
}
