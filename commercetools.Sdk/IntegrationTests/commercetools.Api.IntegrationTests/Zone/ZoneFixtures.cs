using System;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Sdk.Api.Models.Zones;
using static commercetools.Api.IntegrationTests.GenericFixture;
using commercetools.Sdk.Api.Extensions;

namespace commercetools.Api.IntegrationTests.Zone
{
    public class ZoneFixtures
    {
        #region DraftBuilds

        public static ZoneDraft DefaultZoneDraft(ZoneDraft zoneDraft)
        {
            var randomInt = TestingUtility.RandomInt();
            var randomStr = TestingUtility.RandomString();

            zoneDraft.Key = $"Test-Key-{randomInt}";
            zoneDraft.Name = $"Test-Name-{randomStr}";
            zoneDraft.Description = $"Test-Desc-{randomStr}";

            return zoneDraft;
        }

        #endregion

        public static ZoneDraft DefaultZoneDraftWithKey(ZoneDraft draft, string key)
        {
            var zoneDraft = DefaultZoneDraft(draft);
            zoneDraft.Key = key;

            return zoneDraft;
        }

        public static async Task<IZone> CreateZone(IClient client,
            ZoneDraft zoneDraft)
        {
            try
            {
                return await client
                    .WithApi()
                    .WithProjectKey(DefaultProjectKey)
                    .Zones()
                    .Post(zoneDraft)
                    .ExecuteAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static async Task DeleteZone(IClient client, IZone zone)
        {
            try
            {
                await client
                    .WithApi()
                    .WithProjectKey(DefaultProjectKey)
                    .Zones()
                    .WithId(zone.Id)
                    .Delete()
                    .WithVersion(zone.Version)
                    .ExecuteAsync();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        #region

        public static async Task WithZone(IClient client,
            Func<ZoneDraft, ZoneDraft> draftAction,
            Action<IZone> func)
        {
            await With(client, new ZoneDraft(), draftAction, func, CreateZone,
                DeleteZone);
        }

        public static async Task WithZone(IClient client,
            Func<ZoneDraft, ZoneDraft> draftAction,
            Func<IZone, Task> func)
        {
            await WithAsync(client, new ZoneDraft(), draftAction, func, CreateZone,
                DeleteZone);
        }

        public static async Task WithUpdateableZone(IClient client,
            Func<IZone, Task<IZone>> func)
        {
            await WithUpdateableAsync(client, new ZoneDraft(), DefaultZoneDraft, func,
                CreateZone,
                DeleteZone);
        }

        #endregion
    }
}