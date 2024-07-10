using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StoreLanguagesChangedMessagePayloadQueryBuilderDsl
    {
        public StoreLanguagesChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static StoreLanguagesChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new StoreLanguagesChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreLanguagesChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StoreLanguagesChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StoreLanguagesChangedMessagePayloadQueryBuilderDsl>(p, StoreLanguagesChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<StoreLanguagesChangedMessagePayloadQueryBuilderDsl, string> AddedLanguages()
        {
            return new ComparableCollectionPredicateBuilder<StoreLanguagesChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addedLanguages")),
            p => new CombinationQueryPredicate<StoreLanguagesChangedMessagePayloadQueryBuilderDsl>(p, StoreLanguagesChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<StoreLanguagesChangedMessagePayloadQueryBuilderDsl, string> RemovedLanguages()
        {
            return new ComparableCollectionPredicateBuilder<StoreLanguagesChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("removedLanguages")),
            p => new CombinationQueryPredicate<StoreLanguagesChangedMessagePayloadQueryBuilderDsl>(p, StoreLanguagesChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
