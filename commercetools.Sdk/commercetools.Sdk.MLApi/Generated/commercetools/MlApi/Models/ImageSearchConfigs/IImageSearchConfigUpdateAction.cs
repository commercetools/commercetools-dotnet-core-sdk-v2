using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.ImageSearchConfigs
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.MLApi.Models.ImageSearchConfigs.ImageSearchConfigUpdateAction))]
    [SubTypeDiscriminator("changeStatus", typeof(commercetools.MLApi.Models.ImageSearchConfigs.ChangeStatusUpdateAction))]
    public partial interface IImageSearchConfigUpdateAction
    {
        string Action { get; set; }
    }
}
