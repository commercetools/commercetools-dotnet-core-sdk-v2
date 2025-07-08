using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies
{

    public partial class RecurrencePolicySetDescriptionActionQueryBuilderDsl
    {
        public RecurrencePolicySetDescriptionActionQueryBuilderDsl()
        {
        }

        public static RecurrencePolicySetDescriptionActionQueryBuilderDsl Of()
        {
            return new RecurrencePolicySetDescriptionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurrencePolicySetDescriptionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<RecurrencePolicySetDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<RecurrencePolicySetDescriptionActionQueryBuilderDsl>(p, RecurrencePolicySetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurrencePolicySetDescriptionActionQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurrencePolicySetDescriptionActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                RecurrencePolicySetDescriptionActionQueryBuilderDsl.Of);
        }


    }
}
