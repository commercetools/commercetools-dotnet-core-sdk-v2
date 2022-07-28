using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.Common.TaskToken))]
    public partial interface ITaskToken
    {
        string TaskId { get; set; }

        string UriPath { get; set; }

    }
}
