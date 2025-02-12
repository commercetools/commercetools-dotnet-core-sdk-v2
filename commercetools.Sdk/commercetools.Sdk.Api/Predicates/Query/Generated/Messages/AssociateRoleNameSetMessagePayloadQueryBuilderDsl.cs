// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class AssociateRoleNameSetMessagePayloadQueryBuilderDsl
    {
        public AssociateRoleNameSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static AssociateRoleNameSetMessagePayloadQueryBuilderDsl Of()
        {
            return new AssociateRoleNameSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssociateRoleNameSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<AssociateRoleNameSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<AssociateRoleNameSetMessagePayloadQueryBuilderDsl>(p, AssociateRoleNameSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRoleNameSetMessagePayloadQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<AssociateRoleNameSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<AssociateRoleNameSetMessagePayloadQueryBuilderDsl>(p, AssociateRoleNameSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
