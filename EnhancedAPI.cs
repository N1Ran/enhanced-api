using NLog;
using Torch;
using Torch.API;

namespace Enhanced_API {
    public class EnhancedAPI {
        public class EnhancedAPIPlugin : TorchPluginBase {
        public static EnhancedAPIPlugin Instance { get; set; }
            public static readonly Logger Log = LogManager.GetLogger("EnhancedAPI");

            public override void Init(ITorchBase torch) {
                base.Init(torch);
                Instance = this;
                var server = new Enhanced_API.Server();
                server.Start();
            }
        }
    }
}
