using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerSetDateOfBirthAction : ICustomerSetDateOfBirthAction
    {
        public string Action { get; set; }

        public Date? DateOfBirth { get; set; }
        public CustomerSetDateOfBirthAction()
        {
            this.Action = "setDateOfBirth";
        }
    }
}
