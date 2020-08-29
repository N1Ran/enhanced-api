using Nancy;
using NLog;
using System;
using Torch;
using Torch.API;
using Torch.Collections;
using Torch.Utils;
using Torch.Commands;
using Torch.Commands.Permissions;
using VRage.Game.ModAPI;
using Torch.Managers;
using Torch.API.Managers;

namespace Enhanced_API.Routes {
    public class GiveRoutes : NancyModule {
        public static Logger Log = LogManager.GetLogger("EnhancedAPI");
        public GiveRoutes() {
            Get("/v1/player/{steamId}", parameters => {
                try {
                    ulong steamId = Convert.ToUInt64(parameters.steamId);

                    IMyPlayer player = EnhancedAPIPlugin.Instance.Torch.CurrentSession.Managers.GetManager<IMultiplayerManagerBase>().GetPlayerBySteamId(steamId);

                    return player;
                } catch {
                    Log.Info($"Did not retrieve player with given steam id: {parameters.steamId}");
                    return null;
                }
            });
        }
    }
}
