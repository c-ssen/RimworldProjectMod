using System;
using Verse;
using HarmonyLib;
using RimWorld;

namespace ProjectMod
{
	[StaticConstructorOnStartup]
	public static class ProjectMod
	{
		static ProjectMod()
		{
			// Fires second
			Log.Message("Static Project Mod Class Loaded");

			Harmony harmony = new Harmony("rimworld.mod.cssen.projectmod");
			harmony.PatchAll();
		}
	}

	public class ProjectModConfig : Mod
	{
		public ProjectModConfig(ModContentPack content) : base(content)
		{
			// Fires first
			Log.Message("Inherited Project Mod Class Loaded");
		}
	}

	[HarmonyPatch]
	public static class Building_Battery_Patch
	{
		[HarmonyPatch(typeof(Building_Battery), nameof(Building_Battery.PostApplyDamage))]
		[HarmonyPostfix]
		public static void PostApplyDamage_Postfix()
		{
			Log.Message("Harmony Patch Applied");
		}
	}
}