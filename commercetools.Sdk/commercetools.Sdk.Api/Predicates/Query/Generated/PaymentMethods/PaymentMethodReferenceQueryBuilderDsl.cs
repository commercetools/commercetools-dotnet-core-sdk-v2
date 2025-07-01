using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.PaymentMethods
{

    public partial class PaymentMethodReferenceQueryBuilderDsl
    {
        public PaymentMethodReferenceQueryBuilderDsl()
        {
        }

        public static PaymentMethodReferenceQueryBuilderDsl Of()
        {
            return new PaymentMethodReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<PaymentMethodReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<PaymentMethodReferenceQueryBuilderDsl>(p, PaymentMethodReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<PaymentMethodReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<PaymentMethodReferenceQueryBuilderDsl>(p, PaymentMethodReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentMethodReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodQueryBuilderDsl.Of())),
                PaymentMethodReferenceQueryBuilderDsl.Of);
        }


    }
}
