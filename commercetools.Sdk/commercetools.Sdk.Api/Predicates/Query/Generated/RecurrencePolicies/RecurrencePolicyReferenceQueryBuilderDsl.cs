using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies
{

    public partial class RecurrencePolicyReferenceQueryBuilderDsl
    {
        public RecurrencePolicyReferenceQueryBuilderDsl()
        {
        }

        public static RecurrencePolicyReferenceQueryBuilderDsl Of()
        {
            return new RecurrencePolicyReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurrencePolicyReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<RecurrencePolicyReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<RecurrencePolicyReferenceQueryBuilderDsl>(p, RecurrencePolicyReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurrencePolicyReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<RecurrencePolicyReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<RecurrencePolicyReferenceQueryBuilderDsl>(p, RecurrencePolicyReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurrencePolicyReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurrencePolicyReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyQueryBuilderDsl.Of())),
                RecurrencePolicyReferenceQueryBuilderDsl.Of);
        }


    }
}
