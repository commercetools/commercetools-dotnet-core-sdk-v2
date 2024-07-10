// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Channels
{

    public partial class ChannelSetAddressCustomFieldActionQueryBuilderDsl
    {
        public ChannelSetAddressCustomFieldActionQueryBuilderDsl()
        {
        }

        public static ChannelSetAddressCustomFieldActionQueryBuilderDsl Of()
        {
            return new ChannelSetAddressCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ChannelSetAddressCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ChannelSetAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ChannelSetAddressCustomFieldActionQueryBuilderDsl>(p, ChannelSetAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ChannelSetAddressCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ChannelSetAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ChannelSetAddressCustomFieldActionQueryBuilderDsl>(p, ChannelSetAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ChannelSetAddressCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<ChannelSetAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<ChannelSetAddressCustomFieldActionQueryBuilderDsl>(p, ChannelSetAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
