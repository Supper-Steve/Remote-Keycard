using Exiled.API.Features.Items;
using Exiled.Events.EventArgs.Player;

namespace RemoteKeycard
{
    public class EventHandlers
    {
        public static void OnInteractingDoor(InteractingDoorEventArgs ev) 
        {
            if (ev.Door.IsKeycardDoor || ev.Door.IsLocked || ev.Player.IsScp || ev.Player.Items == null || ev.IsAllowed || !Plugin.Instance.Config.InteractingDoor)
                return;
            if (ev.Player.GetEffect(Exiled.API.Enums.EffectType.AmnesiaItems) && !Plugin.Instance.Config.AmnesiaItems)
                return;
            foreach (Item item in ev.Player.Items) 
            {
                if(item is Keycard keycard) 
                { 
                    if(keycard.Permissions >= ev.Door.KeycardPermissions) 
                    { 
                        ev.IsAllowed = true;
                        return;
                    }
                }
            }
        }
        public static void OnInteractingLocker(InteractingLockerEventArgs ev)
        {
            if (ev.Player.IsScp || ev.Player.Items == null || ev.IsAllowed || !Plugin.Instance.Config.InteractingLocker)
                return;
            if (ev.Player.GetEffect(Exiled.API.Enums.EffectType.AmnesiaItems) && !Plugin.Instance.Config.AmnesiaItems)
                return;
            foreach (Item item in ev.Player.Items)
            {
                if (item is Keycard keycard)
                {
                    if (keycard.Permissions >= ev.InteractingChamber.RequiredPermissions)
                    {
                        ev.IsAllowed = true;
                        return;
                    }
                }
            }
        }
        public static void OnUnlockingGenerator(UnlockingGeneratorEventArgs ev)
        {
            if (ev.Player.IsScp || ev.Player.Items == null || ev.IsAllowed || ev.Generator.IsUnlocked || !Plugin.Instance.Config.InteractingGenerator)
                return;
            if (ev.Player.GetEffect(Exiled.API.Enums.EffectType.AmnesiaItems) && !Plugin.Instance.Config.AmnesiaItems)
                return;
            foreach (Item item in ev.Player.Items)
            {
                if (item is Keycard keycard)
                {
                    if (keycard.Permissions >= Exiled.API.Enums.KeycardPermissions.ArmoryLevelTwo)
                    {
                        ev.IsAllowed = true;
                        return;
                    }
                }
            }
        }
        public static void OnActivatingWarheadPanel(ActivatingWarheadPanelEventArgs ev)
        {
            if (ev.Player.IsScp || ev.Player.Items == null || !Plugin.Instance.Config.InteractingWarhead)
                return;
            if (ev.Player.GetEffect(Exiled.API.Enums.EffectType.AmnesiaItems) && !Plugin.Instance.Config.AmnesiaItems)
                return;
            foreach (Item item in ev.Player.Items)
            {
                if (item is Keycard keycard)
                {
                    if (keycard.Permissions == Exiled.API.Enums.KeycardPermissions.AlphaWarhead)
                    {
                        ev.IsAllowed = true;
                        return;
                    }
                }
            }
        }
    }
}
