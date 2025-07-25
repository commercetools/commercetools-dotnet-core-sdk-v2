using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies
{

    public partial class RecurrencePolicyUpdateQueryBuilderDsl
    {
        public RecurrencePolicyUpdateQueryBuilderDsl()
        {
        }

        public static RecurrencePolicyUpdateQueryBuilderDsl Of()
        {
            return new RecurrencePolicyUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurrencePolicyUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<RecurrencePolicyUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<RecurrencePolicyUpdateQueryBuilderDsl>(p, RecurrencePolicyUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurrencePolicyUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurrencePolicyUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyUpdateActionQueryBuilderDsl.Of())),
                RecurrencePolicyUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<RecurrencePolicyUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<RecurrencePolicyUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<RecurrencePolicyUpdateQueryBuilderDsl>(p, RecurrencePolicyUpdateQueryBuilderDsl.Of));
        }

    }
}
