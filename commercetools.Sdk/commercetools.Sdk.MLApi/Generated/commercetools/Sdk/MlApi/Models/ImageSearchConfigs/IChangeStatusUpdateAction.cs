using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.MLApi.Models.ImageSearchConfigs
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.ImageSearchConfigs.ChangeStatusUpdateAction))]
    public partial interface IChangeStatusUpdateAction : IImageSearchConfigUpdateAction
    {
        IImageSearchConfigStatus Status { get; set; }

    }
}
