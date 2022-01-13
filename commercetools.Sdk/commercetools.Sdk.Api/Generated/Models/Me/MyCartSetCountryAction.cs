namespace commercetools.Api.Models.Me
{
    public partial class MyCartSetCountryAction : IMyCartSetCountryAction
    {
        public string Action { get; set; }

        public string Country { get; set; }
        public MyCartSetCountryAction()
        {
            this.Action = "setCountry";
        }
    }
}
