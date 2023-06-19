using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.OrderPatches
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.OrderPatches.OrderPatchImport))]
    public partial interface IOrderPatchImport
    {
        string OrderNumber { get; set; }

        IOrderField Fields { get; set; }

    }
}
