using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [TypeDiscriminator(nameof(Action))]
    [SubTypeDiscriminator("addTransaction", typeof(commercetools.Api.Models.Me.MyPaymentAddTransactionAction))]
    [SubTypeDiscriminator("changeAmountPlanned", typeof(commercetools.Api.Models.Me.MyPaymentChangeAmountPlannedAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Api.Models.Me.MyPaymentSetCustomFieldAction))]
    [SubTypeDiscriminator("setMethodInfoInterface", typeof(commercetools.Api.Models.Me.MyPaymentSetMethodInfoInterfaceAction))]
    [SubTypeDiscriminator("setMethodInfoMethod", typeof(commercetools.Api.Models.Me.MyPaymentSetMethodInfoMethodAction))]
    [SubTypeDiscriminator("setMethodInfoName", typeof(commercetools.Api.Models.Me.MyPaymentSetMethodInfoNameAction))]
    public partial interface IMyPaymentUpdateAction 
    {
        string Action { get; set;}
    }
}
