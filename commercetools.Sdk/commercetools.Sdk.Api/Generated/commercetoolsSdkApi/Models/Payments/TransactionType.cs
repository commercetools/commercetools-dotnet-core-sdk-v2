using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Payments
{
    public enum TransactionType
    {
        [Description("Authorization")]
        Authorization,

        [Description("CancelAuthorization")]
        CancelAuthorization,

        [Description("Charge")]
        Charge,

        [Description("Refund")]
        Refund,

        [Description("Chargeback")]
        Chargeback
    }

    public class TransactionTypeWrapper : ITransactionType
    {
        public string JsonName { get; internal set; }
        public TransactionType? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public new IEnumerator<char> GetEnumerator()
        {
            return JsonName.GetEnumerator();
        }
    }

    [EnumInterfaceCreator(typeof(ITransactionType), "FindEnum")]
    public interface ITransactionType : IJsonName, IEnumerable<char>
    {
        public static ITransactionType Authorization = new TransactionTypeWrapper
        { Value = TransactionType.Authorization, JsonName = "Authorization" };

        public static ITransactionType CancelAuthorization = new TransactionTypeWrapper
        { Value = TransactionType.CancelAuthorization, JsonName = "CancelAuthorization" };

        public static ITransactionType Charge = new TransactionTypeWrapper
        { Value = TransactionType.Charge, JsonName = "Charge" };

        public static ITransactionType Refund = new TransactionTypeWrapper
        { Value = TransactionType.Refund, JsonName = "Refund" };

        public static ITransactionType Chargeback = new TransactionTypeWrapper
        { Value = TransactionType.Chargeback, JsonName = "Chargeback" };

        TransactionType? Value { get; }

        static ITransactionType[] Values()
        {
            return new[]
            {
                 Authorization ,
                 CancelAuthorization ,
                 Charge ,
                 Refund ,
                 Chargeback
             };
        }
        static ITransactionType FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new TransactionTypeWrapper() { JsonName = value };
        }
    }
}
