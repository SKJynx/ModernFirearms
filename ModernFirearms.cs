using Terraria.ModLoader;

namespace ModernFirearms
{
	class ModernFirearms : Mod
	{
		public ModernFirearms()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
