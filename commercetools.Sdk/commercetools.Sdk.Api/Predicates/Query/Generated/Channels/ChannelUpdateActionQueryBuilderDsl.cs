using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Channels
{

    public partial class ChannelUpdateActionQueryBuilderDsl
    {
        public ChannelUpdateActionQueryBuilderDsl()
        {
        }

        public static ChannelUpdateActionQueryBuilderDsl Of()
        {
            return new ChannelUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ChannelUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ChannelUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ChannelUpdateActionQueryBuilderDsl>(p, ChannelUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ChannelUpdateActionQueryBuilderDsl> AsAddRoles(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelAddRolesActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelAddRolesActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelAddRolesActionQueryBuilderDsl.Of()),
                ChannelUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ChannelUpdateActionQueryBuilderDsl> AsChangeDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelChangeDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelChangeDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelChangeDescriptionActionQueryBuilderDsl.Of()),
                ChannelUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ChannelUpdateActionQueryBuilderDsl> AsChangeKey(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelChangeKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelChangeKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelChangeKeyActionQueryBuilderDsl.Of()),
                ChannelUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ChannelUpdateActionQueryBuilderDsl> AsChangeName(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelChangeNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelChangeNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelChangeNameActionQueryBuilderDsl.Of()),
                ChannelUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ChannelUpdateActionQueryBuilderDsl> AsRemoveRoles(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelRemoveRolesActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelRemoveRolesActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelRemoveRolesActionQueryBuilderDsl.Of()),
                ChannelUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ChannelUpdateActionQueryBuilderDsl> AsSetAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelSetAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelSetAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelSetAddressActionQueryBuilderDsl.Of()),
                ChannelUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ChannelUpdateActionQueryBuilderDsl> AsSetAddressCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelSetAddressCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelSetAddressCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelSetAddressCustomFieldActionQueryBuilderDsl.Of()),
                ChannelUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ChannelUpdateActionQueryBuilderDsl> AsSetAddressCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelSetAddressCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelSetAddressCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelSetAddressCustomTypeActionQueryBuilderDsl.Of()),
                ChannelUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ChannelUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelSetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelSetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelSetCustomFieldActionQueryBuilderDsl.Of()),
                ChannelUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ChannelUpdateActionQueryBuilderDsl> AsSetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelSetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelSetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelSetCustomTypeActionQueryBuilderDsl.Of()),
                ChannelUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ChannelUpdateActionQueryBuilderDsl> AsSetGeoLocation(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelSetGeoLocationActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelSetGeoLocationActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelSetGeoLocationActionQueryBuilderDsl.Of()),
                ChannelUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ChannelUpdateActionQueryBuilderDsl> AsSetRoles(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelSetRolesActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelSetRolesActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelSetRolesActionQueryBuilderDsl.Of()),
                ChannelUpdateActionQueryBuilderDsl.Of);
        }
    }
}
