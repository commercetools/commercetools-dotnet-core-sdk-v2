using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CustomerGroups
{
    [DeserializeAs(typeof(commercetools.Api.Models.CustomerGroups.CustomerGroupChangeNameAction))]
    public partial interface ICustomerGroupChangeNameAction : ICustomerGroupUpdateAction
    {
        string Name { get; set; }
    }
}
