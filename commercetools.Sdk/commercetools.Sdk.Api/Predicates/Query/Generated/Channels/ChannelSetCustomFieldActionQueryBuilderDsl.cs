// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Channels
{

    public partial class ChannelSetCustomFieldActionQueryBuilderDsl
    {
        public ChannelSetCustomFieldActionQueryBuilderDsl()
        {
        }

        public static ChannelSetCustomFieldActionQueryBuilderDsl Of()
        {
            return new ChannelSetCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ChannelSetCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ChannelSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ChannelSetCustomFieldActionQueryBuilderDsl>(p, ChannelSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ChannelSetCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ChannelSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ChannelSetCustomFieldActionQueryBuilderDsl>(p, ChannelSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ChannelSetCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<ChannelSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<ChannelSetCustomFieldActionQueryBuilderDsl>(p, ChannelSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
