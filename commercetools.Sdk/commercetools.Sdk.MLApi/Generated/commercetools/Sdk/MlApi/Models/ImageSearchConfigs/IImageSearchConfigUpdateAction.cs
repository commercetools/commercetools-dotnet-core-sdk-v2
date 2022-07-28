using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.ImageSearchConfigs
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.MLApi.Models.ImageSearchConfigs.ImageSearchConfigUpdateAction))]
    [SubTypeDiscriminator("changeStatus", typeof(commercetools.Sdk.MLApi.Models.ImageSearchConfigs.ChangeStatusUpdateAction))]
    public partial interface IImageSearchConfigUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.MLApi.Models.ImageSearchConfigs.ChangeStatusUpdateAction ChangeStatus(Action<commercetools.Sdk.MLApi.Models.ImageSearchConfigs.ChangeStatusUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.MLApi.Models.ImageSearchConfigs.ChangeStatusUpdateAction();
            init?.Invoke(t);
            return t;
        }
    }
}
