using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.DiscountCodes
{

    public partial class DiscountCodeSetCustomTypeActionQueryBuilderDsl
    {
        public DiscountCodeSetCustomTypeActionQueryBuilderDsl()
        {
        }

        public static DiscountCodeSetCustomTypeActionQueryBuilderDsl Of()
        {
            return new DiscountCodeSetCustomTypeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountCodeSetCustomTypeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<DiscountCodeSetCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<DiscountCodeSetCustomTypeActionQueryBuilderDsl>(p, DiscountCodeSetCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountCodeSetCustomTypeActionQueryBuilderDsl> Type(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeSetCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("type"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl.Of())),
                DiscountCodeSetCustomTypeActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DiscountCodeSetCustomTypeActionQueryBuilderDsl> Fields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeSetCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl.Of())),
                DiscountCodeSetCustomTypeActionQueryBuilderDsl.Of);
        }


    }
}
