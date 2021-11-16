using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.ImageSearchConfigs
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.ImageSearchConfigs.ChangeStatusUpdateAction))]
    public partial interface IChangeStatusUpdateAction : IImageSearchConfigUpdateAction
    {
        IImageSearchConfigStatus Status { get; set; }
    }
}
