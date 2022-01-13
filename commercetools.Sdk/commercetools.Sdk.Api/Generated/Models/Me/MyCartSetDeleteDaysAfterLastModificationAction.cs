namespace commercetools.Api.Models.Me
{
    public partial class MyCartSetDeleteDaysAfterLastModificationAction : IMyCartSetDeleteDaysAfterLastModificationAction
    {
        public string Action { get; set; }

        public int? DeleteDaysAfterLastModification { get; set; }
        public MyCartSetDeleteDaysAfterLastModificationAction()
        {
            this.Action = "setDeleteDaysAfterLastModification";
        }
    }
}
