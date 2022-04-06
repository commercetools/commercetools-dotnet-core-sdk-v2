using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    public enum TransactionState
    {
        [Description("Initial")]
        Initial,

        [Description("Pending")]
        Pending,

        [Description("Success")]
        Success,

        [Description("Failure")]
        Failure
    }

    public class TransactionStateWrapper : ITransactionState
    {
        public string JsonName { get; internal set; }
        public TransactionState? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }
    }

    [EnumInterfaceCreator(typeof(ITransactionState), "FindEnum")]
    public interface ITransactionState : IJsonName
    {
        public static ITransactionState Initial = new TransactionStateWrapper
        { Value = TransactionState.Initial, JsonName = "Initial" };

        public static ITransactionState Pending = new TransactionStateWrapper
        { Value = TransactionState.Pending, JsonName = "Pending" };

        public static ITransactionState Success = new TransactionStateWrapper
        { Value = TransactionState.Success, JsonName = "Success" };

        public static ITransactionState Failure = new TransactionStateWrapper
        { Value = TransactionState.Failure, JsonName = "Failure" };

        TransactionState? Value { get; }

        static ITransactionState[] Values()
        {
            return new[]
            {
                 Initial ,
                 Pending ,
                 Success ,
                 Failure
             };
        }
        static ITransactionState FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new TransactionStateWrapper() { JsonName = value };
        }
    }
}
