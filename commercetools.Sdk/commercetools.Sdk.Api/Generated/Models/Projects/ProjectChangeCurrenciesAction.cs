using System.Collections.Generic;


namespace commercetools.Api.Models.Projects
{
    public partial class ProjectChangeCurrenciesAction : IProjectChangeCurrenciesAction
    {
        public string Action { get; set; }

        public List<string> Currencies { get; set; }
        public ProjectChangeCurrenciesAction()
        {
            this.Action = "changeCurrencies";
        }
    }
}
