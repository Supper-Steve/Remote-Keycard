using Exiled.API.Features;
using System;

namespace RemoteKeycard
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance { get; } = new Plugin();
        public override Version Version { get; } = new Version(0, 0, 1, 1);
        public override string Author { get; } = "史蒂夫";
        public override string Name { get; } = "免手持卡-Exiled";
        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.InteractingDoor += EventHandlers.OnInteractingDoor;
            Exiled.Events.Handlers.Player.InteractingLocker += EventHandlers.OnInteractingLocker;
            Exiled.Events.Handlers.Player.UnlockingGenerator += EventHandlers.OnUnlockingGenerator;
            Exiled.Events.Handlers.Player.ActivatingWarheadPanel += EventHandlers.OnActivatingWarheadPanel;
            Log.Info("已启动免手持卡插件!");
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.InteractingDoor -= EventHandlers.OnInteractingDoor;
            Exiled.Events.Handlers.Player.InteractingLocker -= EventHandlers.OnInteractingLocker;
            Exiled.Events.Handlers.Player.UnlockingGenerator -= EventHandlers.OnUnlockingGenerator;
            Exiled.Events.Handlers.Player.ActivatingWarheadPanel -= EventHandlers.OnActivatingWarheadPanel;
            Log.Info("已关闭免手持卡插件!");
            base.OnDisabled();
        }
    }
}
