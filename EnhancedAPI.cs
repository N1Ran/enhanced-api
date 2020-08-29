using NLog;
using Torch;
using Torch.API;

namespace Enhanced_API {
    public class EnhancedAPI {
        public class EnhancedAPIPlugin : TorchPluginBase {

            public static readonly Logger Log = LogManager.GetLogger("EnhancedAPI");

            public override void Init(ITorchBase torch) {
                base.Init(torch);
                var server = new Enhanced_API.Server();
                server.Start();
            }
        }
    }
}
