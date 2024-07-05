using Holographic.Mods;
using StupidTemplate.Classes;
using StupidTemplate.Mods;
using static StupidTemplate.Settings;

namespace StupidTemplate.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "SpeedBoost", method =() => SpeedBoost.SpeedBoostMod(), toolTip = "Gives a speed boost. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Fly", method =() => Fly.FlyMod(), toolTip = "Makes you fly. UND", isTogglable = true},
                new ButtonInfo { buttonText = "MosaSpeedBoost", method =() => MosaSpeed.MosaSpeedMod(), toolTip = "Gives a slight speed boost. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Platforms", method =() => Platforms.PlatformsMod(), toolTip = "spawns platforms when pressing right and left grab. UND", isTogglable = true},
                new ButtonInfo { buttonText = "LongArms", method =() => LongArms.LongArmsMod(), toolTip = "Increases your arm length. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Ghost", method =() => ghost.GhostMonkeMod(), toolTip = "freezes your rig and lets you move around then teleports it back to you. UND", isTogglable = true},
                new ButtonInfo { buttonText = "SlideControl", method =() => SlideControl.SlideControlMod(), toolTip = "Makes its easier to control when on ice. UND", isTogglable = true},
                new ButtonInfo { buttonText = "ESPBox", method =() => EspBox.ESPboxMod(), toolTip = "makes it so you can see people through walls. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Big", method =() => Big.LargeScaleMod(), toolTip = "Makes you Bigger. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Antireport", method =() => AntiReport.Antireportdisconnect(), toolTip = "as soon as some reports you you get disconected. UND", isTogglable = true},
                new ButtonInfo { buttonText = "small", method =() => Small.SmallMod(), toolTip = "Makes you smaller. UND", isTogglable = true},
                new ButtonInfo { buttonText = "TagGun", method =() => TagGun.TagGunMod(), toolTip = "shoot someone and they get tagged. UND", isTogglable = true},
                new ButtonInfo { buttonText = "AntiTag", method =() => AntiTag.AntiTagMod(), toolTip = "you cant get tagged. UND", isTogglable = true},
                new ButtonInfo { buttonText = "noclip", method =() => Noclip.NoClipV1(), toolTip = "Gives you the abilitie to phase through objects. UND", isTogglable = true},
            },

            new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Menu", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Movement", method =() => SettingsMods.MovementSettings(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
                new ButtonInfo { buttonText = "Projectile", method =() => SettingsMods.ProjectileSettings(), isTogglable = false, toolTip = "Opens the projectile settings for the menu."},
            },

            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
            },

            new ButtonInfo[] { // Movement Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
            },

            new ButtonInfo[] { // Projectile Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
            },
        };
    }
}
