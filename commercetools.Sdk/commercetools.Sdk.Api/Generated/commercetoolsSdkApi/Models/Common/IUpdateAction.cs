using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.UpdateAction))]
    public partial interface IUpdateAction
    {
        string Action { get; set; }

    }
}
