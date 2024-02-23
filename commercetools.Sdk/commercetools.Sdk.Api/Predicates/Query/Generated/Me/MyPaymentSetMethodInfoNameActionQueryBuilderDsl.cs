using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyPaymentSetMethodInfoNameActionQueryBuilderDsl
    {
        public MyPaymentSetMethodInfoNameActionQueryBuilderDsl()
        {
        }

        public static MyPaymentSetMethodInfoNameActionQueryBuilderDsl Of()
        {
            return new MyPaymentSetMethodInfoNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyPaymentSetMethodInfoNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyPaymentSetMethodInfoNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyPaymentSetMethodInfoNameActionQueryBuilderDsl>(p, MyPaymentSetMethodInfoNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyPaymentSetMethodInfoNameActionQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyPaymentSetMethodInfoNameActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                MyPaymentSetMethodInfoNameActionQueryBuilderDsl.Of);
        }


    }
}
