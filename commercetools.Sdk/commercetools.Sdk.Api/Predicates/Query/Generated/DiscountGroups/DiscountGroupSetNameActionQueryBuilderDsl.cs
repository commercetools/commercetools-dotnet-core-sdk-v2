using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.DiscountGroups
{

    public partial class DiscountGroupSetNameActionQueryBuilderDsl
    {
        public DiscountGroupSetNameActionQueryBuilderDsl()
        {
        }

        public static DiscountGroupSetNameActionQueryBuilderDsl Of()
        {
            return new DiscountGroupSetNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountGroupSetNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<DiscountGroupSetNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<DiscountGroupSetNameActionQueryBuilderDsl>(p, DiscountGroupSetNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountGroupSetNameActionQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountGroupSetNameActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                DiscountGroupSetNameActionQueryBuilderDsl.Of);
        }


    }
}
