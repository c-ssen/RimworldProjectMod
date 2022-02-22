using System;
using Verse;

namespace ProjectMod
{
    [StaticConstructorOnStartup]
    public static class ProjectMod
    {
        static ProjectMod()
		{
            Log.Message("Static Project Mod Class Loaded");
		}
    }

	public class ProjectModConfig : Mod
	{
		public ProjectModConfig(ModContentPack content) : base(content)
		{
			Log.Message("Inherited Project Mod Class Loaded");
		}
	}
}