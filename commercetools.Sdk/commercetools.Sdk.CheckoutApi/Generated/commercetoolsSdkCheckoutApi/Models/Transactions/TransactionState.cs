using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Transactions
{
    public enum TransactionState
    {
        [Description("Initial")]
        Initial,

        [Description("Pending")]
        Pending,

        [Description("Completed")]
        Completed,

        [Description("Failed")]
        Failed
    }

    public class TransactionStateWrapper : ITransactionState
    {
        public string JsonName { get; internal set; }
        public TransactionState? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(ITransactionState), "FindEnum")]
    public interface ITransactionState : IJsonName, IEnumerable<char>
    {
        public static ITransactionState Initial = new TransactionStateWrapper
        { Value = TransactionState.Initial, JsonName = "Initial" };

        public static ITransactionState Pending = new TransactionStateWrapper
        { Value = TransactionState.Pending, JsonName = "Pending" };

        public static ITransactionState Completed = new TransactionStateWrapper
        { Value = TransactionState.Completed, JsonName = "Completed" };

        public static ITransactionState Failed = new TransactionStateWrapper
        { Value = TransactionState.Failed, JsonName = "Failed" };

        TransactionState? Value { get; }

        static ITransactionState[] Values()
        {
            return new[]
            {
                 Initial ,
                 Pending ,
                 Completed ,
                 Failed
             };
        }
        static ITransactionState FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new TransactionStateWrapper() { JsonName = value };
        }
    }
}
