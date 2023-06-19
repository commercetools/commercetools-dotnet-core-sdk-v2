using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Channels
{

    public partial class ChannelSetAddressActionQueryBuilderDsl
    {
        public ChannelSetAddressActionQueryBuilderDsl()
        {
        }

        public static ChannelSetAddressActionQueryBuilderDsl Of()
        {
            return new ChannelSetAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ChannelSetAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ChannelSetAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ChannelSetAddressActionQueryBuilderDsl>(p, ChannelSetAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ChannelSetAddressActionQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelSetAddressActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                ChannelSetAddressActionQueryBuilderDsl.Of);
        }


    }
}
