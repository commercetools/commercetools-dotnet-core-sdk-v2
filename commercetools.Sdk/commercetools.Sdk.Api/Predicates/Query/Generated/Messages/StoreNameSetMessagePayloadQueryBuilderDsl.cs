using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StoreNameSetMessagePayloadQueryBuilderDsl
    {
        public StoreNameSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static StoreNameSetMessagePayloadQueryBuilderDsl Of()
        {
            return new StoreNameSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreNameSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StoreNameSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StoreNameSetMessagePayloadQueryBuilderDsl>(p, StoreNameSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreNameSetMessagePayloadQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreNameSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                StoreNameSetMessagePayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StoreNameSetMessagePayloadQueryBuilderDsl> NameAllLocales(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreNameSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("nameAllLocales"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                StoreNameSetMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreNameSetMessagePayloadQueryBuilderDsl> NameAllLocales()
        {
            return new CollectionPredicateBuilder<StoreNameSetMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("nameAllLocales")),
                    p => new CombinationQueryPredicate<StoreNameSetMessagePayloadQueryBuilderDsl>(p, StoreNameSetMessagePayloadQueryBuilderDsl.Of));
        }

    }
}
