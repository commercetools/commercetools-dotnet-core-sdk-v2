using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Api.Models.Payments
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
   }
   [EnumInterfaceCreator(typeof(ITransactionType), "FindEnum")]
   public interface ITransactionType : IJsonName
   {
        public static ITransactionType Authorization = new TransactionTypeWrapper
         {Value = TransactionType.Authorization, JsonName = "Authorization"}; 
       
        public static ITransactionType CancelAuthorization = new TransactionTypeWrapper
         {Value = TransactionType.CancelAuthorization, JsonName = "CancelAuthorization"}; 
       
        public static ITransactionType Charge = new TransactionTypeWrapper
         {Value = TransactionType.Charge, JsonName = "Charge"}; 
       
        public static ITransactionType Refund = new TransactionTypeWrapper
         {Value = TransactionType.Refund, JsonName = "Refund"}; 
       
        public static ITransactionType Chargeback = new TransactionTypeWrapper
         {Value = TransactionType.Chargeback, JsonName = "Chargeback"}; 
       
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
           return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new TransactionTypeWrapper() {JsonName = value};
        }
   }
}
