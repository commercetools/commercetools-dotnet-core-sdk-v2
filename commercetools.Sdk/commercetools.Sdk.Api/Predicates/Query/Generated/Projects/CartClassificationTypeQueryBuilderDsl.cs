using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class CartClassificationTypeQueryBuilderDsl
    {
        public CartClassificationTypeQueryBuilderDsl()
        {
        }

        public static CartClassificationTypeQueryBuilderDsl Of()
        {
            return new CartClassificationTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartClassificationTypeQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartClassificationTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartClassificationTypeQueryBuilderDsl>(p, CartClassificationTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartClassificationTypeQueryBuilderDsl> Values(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldLocalizedEnumValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldLocalizedEnumValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartClassificationTypeQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("values"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldLocalizedEnumValueQueryBuilderDsl.Of())),
                CartClassificationTypeQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartClassificationTypeQueryBuilderDsl> Values()
        {
            return new CollectionPredicateBuilder<CartClassificationTypeQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("values")),
                    p => new CombinationQueryPredicate<CartClassificationTypeQueryBuilderDsl>(p, CartClassificationTypeQueryBuilderDsl.Of));
        }

    }
}
