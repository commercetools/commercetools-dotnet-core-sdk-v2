using System;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Models.Zones;
using static commercetools.Api.IntegrationTests.GenericFixture;

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

        public static async Task<IZone> CreateZone(ProjectApiRoot client,
            ZoneDraft zoneDraft)
        {
            try
            {
                return await client
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

        public static async Task DeleteZone(ProjectApiRoot client, IZone zone)
        {
            try
            {
                await client
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

        public static async Task WithZone(ProjectApiRoot client,
            Func<ZoneDraft, ZoneDraft> draftAction,
            Action<IZone> func)
        {
            await With(client, new ZoneDraft(), draftAction, func, CreateZone,
                DeleteZone);
        }

        public static async Task WithZone(ProjectApiRoot client,
            Func<ZoneDraft, ZoneDraft> draftAction,
            Func<IZone, Task> func)
        {
            await WithAsync(client, new ZoneDraft(), draftAction, func, CreateZone,
                DeleteZone);
        }

        public static async Task WithUpdateableZone(ProjectApiRoot client,
            Func<IZone, Task<IZone>> func)
        {
            await WithUpdateableAsync(client, new ZoneDraft(), DefaultZoneDraft, func,
                CreateZone,
                DeleteZone);
        }

        #endregion
    }
}