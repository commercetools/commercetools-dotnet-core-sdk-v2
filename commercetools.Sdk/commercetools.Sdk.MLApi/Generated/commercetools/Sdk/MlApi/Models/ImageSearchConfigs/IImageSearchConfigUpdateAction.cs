using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.ImageSearchConfigs
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.MLApi.Models.ImageSearchConfigs.ImageSearchConfigUpdateAction))]
    [SubTypeDiscriminator("changeStatus", typeof(commercetools.Sdk.MLApi.Models.ImageSearchConfigs.ChangeStatusUpdateAction))]
    public partial interface IImageSearchConfigUpdateAction
    {
        string Action { get; set; }
    }
}
