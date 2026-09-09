using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class VariantStagedChangesRemovedMessagePayloadQueryBuilderDsl
    {
        public VariantStagedChangesRemovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static VariantStagedChangesRemovedMessagePayloadQueryBuilderDsl Of()
        {
            return new VariantStagedChangesRemovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantStagedChangesRemovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<VariantStagedChangesRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<VariantStagedChangesRemovedMessagePayloadQueryBuilderDsl>(p, VariantStagedChangesRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantStagedChangesRemovedMessagePayloadQueryBuilderDsl> Product(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantStagedChangesRemovedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("product"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl.Of())),
                VariantStagedChangesRemovedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
