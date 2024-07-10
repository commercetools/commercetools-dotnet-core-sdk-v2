using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyPaymentSetTransactionCustomFieldActionQueryBuilderDsl
    {
        public MyPaymentSetTransactionCustomFieldActionQueryBuilderDsl()
        {
        }

        public static MyPaymentSetTransactionCustomFieldActionQueryBuilderDsl Of()
        {
            return new MyPaymentSetTransactionCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyPaymentSetTransactionCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyPaymentSetTransactionCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyPaymentSetTransactionCustomFieldActionQueryBuilderDsl>(p, MyPaymentSetTransactionCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyPaymentSetTransactionCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<MyPaymentSetTransactionCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<MyPaymentSetTransactionCustomFieldActionQueryBuilderDsl>(p, MyPaymentSetTransactionCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyPaymentSetTransactionCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<MyPaymentSetTransactionCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<MyPaymentSetTransactionCustomFieldActionQueryBuilderDsl>(p, MyPaymentSetTransactionCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
