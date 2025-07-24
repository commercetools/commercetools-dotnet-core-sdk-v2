using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies
{

    public partial class RecurrencePolicySetNameActionQueryBuilderDsl
    {
        public RecurrencePolicySetNameActionQueryBuilderDsl()
        {
        }

        public static RecurrencePolicySetNameActionQueryBuilderDsl Of()
        {
            return new RecurrencePolicySetNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurrencePolicySetNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<RecurrencePolicySetNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<RecurrencePolicySetNameActionQueryBuilderDsl>(p, RecurrencePolicySetNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurrencePolicySetNameActionQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurrencePolicySetNameActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                RecurrencePolicySetNameActionQueryBuilderDsl.Of);
        }


    }
}
