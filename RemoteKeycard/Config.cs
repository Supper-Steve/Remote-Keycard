using Exiled.API.Interfaces;
using System.ComponentModel;

namespace RemoteKeycard
{
    public sealed class Config : IConfig
    {
        [Description("启动免手持卡")]
        public bool IsEnabled { get; set; } = true;
        [Description("启动免手持卡-Debug")]
        public bool Debug { get; set; } = false;
        [Description("免手持卡对门有效")]
        public bool InteractingDoor { get; set; } = true;
        [Description("免手持卡对物品柜有效")]
        public bool InteractingLocker { get; set; } = true;
        [Description("免手持卡对发电机有效")]
        public bool InteractingGenerator { get; set; } = true;
        [Description("免手持卡对核弹有效")]
        public bool InteractingWarhead { get; set; } = true;
        [Description("拥有AmnesiaItems效果的玩家是否能免手持卡")]
        public bool AmnesiaItems { get; set; } = false;
    }
}
