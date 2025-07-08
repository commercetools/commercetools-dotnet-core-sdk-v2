using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Common.CustomerKeyReference))]
    public partial interface ICustomerKeyReference : IKeyReference
    {
        new string Key { get; set; }

    }
}
