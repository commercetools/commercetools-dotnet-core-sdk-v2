using commercetools.Base.Models;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerDateOfBirthSetMessagePayload : ICustomerDateOfBirthSetMessagePayload
    {
        public string Type { get; set; }

        public Date? DateOfBirth { get; set; }
        public CustomerDateOfBirthSetMessagePayload()
        {
            this.Type = "CustomerDateOfBirthSet";
        }
    }
}
