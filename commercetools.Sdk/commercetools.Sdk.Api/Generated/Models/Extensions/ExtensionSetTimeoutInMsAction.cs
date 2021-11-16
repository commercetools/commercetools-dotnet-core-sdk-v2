namespace commercetools.Api.Models.Extensions
{
    public partial class ExtensionSetTimeoutInMsAction : IExtensionSetTimeoutInMsAction
    {
        public string Action { get; set;}
        
        public int? TimeoutInMs { get; set;}
        public ExtensionSetTimeoutInMsAction()
        { 
           this.Action = "setTimeoutInMs";
        }
    }
}
