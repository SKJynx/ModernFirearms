using Terraria;
using Terraria.ModLoader;

namespace ModernFirearms.Gores
{
	public class BulletCasing : ModGore
	{
		public override void OnSpawn(Gore gore)
		{
			gore.numFrames = 1;
			gore.sticky = false;
			gore.light = 0f;
			gore.scale = 0.7f;
		}

		public override bool Update(Gore gore)
		{
			if (gore.velocity.Y == 0f)
			{
				gore.velocity.X *= 0.99f;
			}
			return true;
		}
	}
}
