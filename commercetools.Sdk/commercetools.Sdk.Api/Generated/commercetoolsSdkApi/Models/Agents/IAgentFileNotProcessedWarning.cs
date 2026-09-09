using commercetools.Sdk.Api.Models.Warnings;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Agents
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Agents.AgentFileNotProcessedWarning))]
    public partial interface IAgentFileNotProcessedWarning : IWarningObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        string FileName { get; set; }

    }
}
