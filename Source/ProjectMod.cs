using System;
using Verse;

namespace ProjectMod
{
    [StaticConstructorOnStartup]
    public static class ProjectMod
    {
        static ProjectMod()
		{
			// Fires second
            Log.Message("Static Project Mod Class Loaded");
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
}