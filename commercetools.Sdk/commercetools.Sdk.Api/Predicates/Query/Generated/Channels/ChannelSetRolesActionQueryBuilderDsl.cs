// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Channels
{

    public partial class ChannelSetRolesActionQueryBuilderDsl
    {
        public ChannelSetRolesActionQueryBuilderDsl()
        {
        }

        public static ChannelSetRolesActionQueryBuilderDsl Of()
        {
            return new ChannelSetRolesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ChannelSetRolesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ChannelSetRolesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ChannelSetRolesActionQueryBuilderDsl>(p, ChannelSetRolesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ChannelSetRolesActionQueryBuilderDsl, string> Roles()
        {
            return new ComparableCollectionPredicateBuilder<ChannelSetRolesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("roles")),
            p => new CombinationQueryPredicate<ChannelSetRolesActionQueryBuilderDsl>(p, ChannelSetRolesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
