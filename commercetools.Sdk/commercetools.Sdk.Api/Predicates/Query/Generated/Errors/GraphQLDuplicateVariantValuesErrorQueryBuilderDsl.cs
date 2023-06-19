using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLDuplicateVariantValuesErrorQueryBuilderDsl
    {
        public GraphQLDuplicateVariantValuesErrorQueryBuilderDsl()
        {
        }

        public static GraphQLDuplicateVariantValuesErrorQueryBuilderDsl Of()
        {
            return new GraphQLDuplicateVariantValuesErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLDuplicateVariantValuesErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLDuplicateVariantValuesErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLDuplicateVariantValuesErrorQueryBuilderDsl>(p, GraphQLDuplicateVariantValuesErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<GraphQLDuplicateVariantValuesErrorQueryBuilderDsl> VariantValues(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.VariantValuesQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.VariantValuesQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLDuplicateVariantValuesErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("variantValues"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.VariantValuesQueryBuilderDsl.Of())),
                GraphQLDuplicateVariantValuesErrorQueryBuilderDsl.Of);
        }


    }
}
