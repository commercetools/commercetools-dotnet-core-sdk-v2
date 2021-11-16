namespace commercetools.Api.Models.Me
{
    public partial class MyCartSetLocaleAction : IMyCartSetLocaleAction
    {
        public string Action { get; set; }

        public string Locale { get; set; }
        public MyCartSetLocaleAction()
        {
            this.Action = "setLocale";
        }
    }
}
