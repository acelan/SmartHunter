# SmartHunter - Monster Hunter: World Overlay

A complete overlay for Monster Hunter: World on PC. Distributed on [Nexus Mods](https://www.nexusmods.com/monsterhunterworld/mods/793). Features include:

- Monster widget - name, health, parts, status effect buildup, and crown.
- Team widget - name and damage meters.
- Player widget - buff, debuff, and equipment/mantle timers.
- Open source - freely learn from and contribute to the project.
- Skinnable - create and distribute your own rich styles and animations with XAML.
- Easy localization - create and distribute your own translations for our international friends.

To support Discord, add Env.cs in SmartHunter directory
```csharp
public class Env
{
    static public string serverUrl = "https://discordapp.com";
    static public string serverPort = "";
    static public string serverRouteDamages = "/api/webhooks/ooo/xxx";
}
```

## Requirements
- Windows.
- [The latest .NET Framework runtime](https://dotnet.microsoft.com/download/dotnet-framework-runtime).

## How to use

- Launch `SmartHunter.exe`.
- Hold `LeftAlt` to view widget locations.
- Click and drag widgets to move them.
- Scroll over widgets to rescale them.

## How to create and use new localizations

- Create a copy of `en-US.json` and rename it for the locale you are translating to.
- Translate the strings in the second part of each key value pair. Do not change the keys.
- Ensure the new file is in the SmartHunter folder.
- Open `Config.json` and point `LocalizationFileName` to the new file.

## How to create and use new skins

- Create a copy of `Default.xaml` and rename it appropriately.
- Make changes to the new file.
- Ensure the new file is in the SmartHunter folder.
- Open `Config.json` and point `SkinFileName` to the new file.

## Credits

- [HelloWorld](https://www.nexusmods.com/monsterhunterworld/users/58674841) for inspiring me with [their overlay](https://www.nexusmods.com/monsterhunterworld/mods/142).
- [Material1](https://www.nexusmods.com/monsterhunterworld/users/61777036) for their efforts in finding monster sizes.
- [hqvrrsc4](https://www.nexusmods.com/monsterhunterworld/users/7950104) for finding player data in [their overlay](https://www.nexusmods.com/monsterhunterworld/mods/88).
- [HelloWorld](https://www.nexusmods.com/monsterhunterworld/users/58674841), [amatess2002](https://www.nexusmods.com/users/59866791), [regretofabreath](https://www.nexusmods.com/monsterhunterworld/users/57977516), and [hawk333](https://www.nexusmods.com/monsterhunterworld/users/1939230) for their efforts in indexing monster parts.

## Disclaimer

Use with care and at your own risk. It is possible to get banned from games for using mods and overlays. There have been reports of people being banned from other games, such as PUBG, if overlays are accidentally left running in the background. To date, there have been no reports of players being banned from Monster Hunter: World for using mods and overlays, but that doesn't preclude it from happening in the future.
