using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class VariantImageAddedMessagePayloadQueryBuilderDsl
    {
        public VariantImageAddedMessagePayloadQueryBuilderDsl()
        {
        }

        public static VariantImageAddedMessagePayloadQueryBuilderDsl Of()
        {
            return new VariantImageAddedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantImageAddedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<VariantImageAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<VariantImageAddedMessagePayloadQueryBuilderDsl>(p, VariantImageAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantImageAddedMessagePayloadQueryBuilderDsl> Image(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantImageAddedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("image"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl.Of())),
                VariantImageAddedMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<VariantImageAddedMessagePayloadQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<VariantImageAddedMessagePayloadQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<VariantImageAddedMessagePayloadQueryBuilderDsl>(p, VariantImageAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
