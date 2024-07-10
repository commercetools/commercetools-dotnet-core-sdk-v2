using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Channels
{

    public partial class ChannelChangeDescriptionActionQueryBuilderDsl
    {
        public ChannelChangeDescriptionActionQueryBuilderDsl()
        {
        }

        public static ChannelChangeDescriptionActionQueryBuilderDsl Of()
        {
            return new ChannelChangeDescriptionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ChannelChangeDescriptionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ChannelChangeDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ChannelChangeDescriptionActionQueryBuilderDsl>(p, ChannelChangeDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ChannelChangeDescriptionActionQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelChangeDescriptionActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ChannelChangeDescriptionActionQueryBuilderDsl.Of);
        }


    }
}
