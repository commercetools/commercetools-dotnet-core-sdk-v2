using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.CustomerGroups
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupUpdateAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupChangeNameAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupSetCustomTypeAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupSetKeyAction))]
    public partial interface ICustomerGroupUpdateAction : commercetools.Sdk.Api.Models.IResourceUpdateAction<ICustomerGroupUpdateAction>
    {
        new string Action { get; set; }
    }
}
