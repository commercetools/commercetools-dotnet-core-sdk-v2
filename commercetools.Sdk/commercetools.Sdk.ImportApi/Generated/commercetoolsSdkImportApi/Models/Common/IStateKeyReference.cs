using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Common.StateKeyReference))]
    public partial interface IStateKeyReference : IKeyReference
    {
        new string Key { get; set; }

    }
}
