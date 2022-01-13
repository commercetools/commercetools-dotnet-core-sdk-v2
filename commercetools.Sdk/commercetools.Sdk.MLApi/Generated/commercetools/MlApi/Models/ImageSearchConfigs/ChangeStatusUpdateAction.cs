namespace commercetools.MLApi.Models.ImageSearchConfigs
{
    public partial class ChangeStatusUpdateAction : IChangeStatusUpdateAction
    {
        public string Action { get; set; }

        public IImageSearchConfigStatus Status { get; set; }
        public ChangeStatusUpdateAction()
        {
            this.Action = "changeStatus";
        }
    }
}
