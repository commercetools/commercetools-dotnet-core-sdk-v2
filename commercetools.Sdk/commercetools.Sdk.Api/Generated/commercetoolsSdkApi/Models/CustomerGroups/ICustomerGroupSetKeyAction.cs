using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CustomerGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupSetKeyAction))]
    public partial interface ICustomerGroupSetKeyAction : ICustomerGroupUpdateAction
    {
        string Key { get; set; }

    }
}
