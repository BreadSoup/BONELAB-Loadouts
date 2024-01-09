using System.Reflection;
using Loadouts;
using MelonLoader;

[assembly: AssemblyTitle(Loadouts.Main.Description)]
[assembly: AssemblyDescription(Loadouts.Main.Description)]
[assembly: AssemblyCompany(Loadouts.Main.Company)]
[assembly: AssemblyProduct(Loadouts.Main.Name)]
[assembly: AssemblyCopyright("Developed by " + Loadouts.Main.Author)]
[assembly: AssemblyTrademark(Loadouts.Main.Company)]
[assembly: AssemblyVersion(Loadouts.Main.Version)]
[assembly: AssemblyFileVersion(Loadouts.Main.Version)]
[assembly: MelonInfo(typeof(Loadouts.Main), Loadouts.Main.Name, Loadouts.Main.Version, Loadouts.Main.Author, Loadouts.Main.DownloadLink)]
[assembly: MelonColor(System.ConsoleColor.White)]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("Stress Level Zero", "BONELAB")]