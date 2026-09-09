namespace commercetools.Sdk.Api.Models.Agents
{

    public partial class AgentFileNotProcessedWarning : IAgentFileNotProcessedWarning
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public string FileName { get; set; }
        public AgentFileNotProcessedWarning()
        {
            this.Code = "FileNotProcessed";
        }
    }
}
