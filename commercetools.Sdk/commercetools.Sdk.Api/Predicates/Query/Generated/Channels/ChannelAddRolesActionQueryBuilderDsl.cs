// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Channels
{

    public partial class ChannelAddRolesActionQueryBuilderDsl
    {
        public ChannelAddRolesActionQueryBuilderDsl()
        {
        }

        public static ChannelAddRolesActionQueryBuilderDsl Of()
        {
            return new ChannelAddRolesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ChannelAddRolesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ChannelAddRolesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ChannelAddRolesActionQueryBuilderDsl>(p, ChannelAddRolesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ChannelAddRolesActionQueryBuilderDsl, string> Roles()
        {
            return new ComparableCollectionPredicateBuilder<ChannelAddRolesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("roles")),
            p => new CombinationQueryPredicate<ChannelAddRolesActionQueryBuilderDsl>(p, ChannelAddRolesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
