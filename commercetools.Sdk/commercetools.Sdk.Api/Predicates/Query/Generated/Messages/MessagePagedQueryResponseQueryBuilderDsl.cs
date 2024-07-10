using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class MessagePagedQueryResponseQueryBuilderDsl
    {
        public MessagePagedQueryResponseQueryBuilderDsl()
        {
        }

        public static MessagePagedQueryResponseQueryBuilderDsl Of()
        {
            return new MessagePagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MessagePagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<MessagePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<MessagePagedQueryResponseQueryBuilderDsl>(p, MessagePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MessagePagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<MessagePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<MessagePagedQueryResponseQueryBuilderDsl>(p, MessagePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MessagePagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<MessagePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<MessagePagedQueryResponseQueryBuilderDsl>(p, MessagePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MessagePagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<MessagePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<MessagePagedQueryResponseQueryBuilderDsl>(p, MessagePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MessagePagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.MessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.MessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessagePagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.MessageQueryBuilderDsl.Of())),
                MessagePagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<MessagePagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<MessagePagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<MessagePagedQueryResponseQueryBuilderDsl>(p, MessagePagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
