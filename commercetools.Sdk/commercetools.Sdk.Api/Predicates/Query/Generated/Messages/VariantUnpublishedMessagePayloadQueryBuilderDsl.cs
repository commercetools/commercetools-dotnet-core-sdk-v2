using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class VariantUnpublishedMessagePayloadQueryBuilderDsl
    {
        public VariantUnpublishedMessagePayloadQueryBuilderDsl()
        {
        }

        public static VariantUnpublishedMessagePayloadQueryBuilderDsl Of()
        {
            return new VariantUnpublishedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantUnpublishedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<VariantUnpublishedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<VariantUnpublishedMessagePayloadQueryBuilderDsl>(p, VariantUnpublishedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantUnpublishedMessagePayloadQueryBuilderDsl> Product(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantUnpublishedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("product"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl.Of())),
                VariantUnpublishedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
