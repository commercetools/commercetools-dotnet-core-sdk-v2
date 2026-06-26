using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.VariantAttributes
{

    public partial class VariantAttributesAttributeMetadataQueryBuilderDsl
    {
        public VariantAttributesAttributeMetadataQueryBuilderDsl()
        {
        }

        public static VariantAttributesAttributeMetadataQueryBuilderDsl Of()
        {
            return new VariantAttributesAttributeMetadataQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantAttributesAttributeMetadataQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<VariantAttributesAttributeMetadataQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<VariantAttributesAttributeMetadataQueryBuilderDsl>(p, VariantAttributesAttributeMetadataQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantAttributesAttributeMetadataQueryBuilderDsl> Label(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantAttributesAttributeMetadataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("label"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                VariantAttributesAttributeMetadataQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<VariantAttributesAttributeMetadataQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<VariantAttributesAttributeMetadataQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<VariantAttributesAttributeMetadataQueryBuilderDsl>(p, VariantAttributesAttributeMetadataQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
