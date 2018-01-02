using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ModernFirearms.Projectiles //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{    
    public class SniperBullet : ModProjectile 
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("SniperBullet");
		}
        public override void SetDefaults()
        {
            projectile.width = 4; //Set the hitbox width
            projectile.height = 10; //Set the hitbox height
            projectile.timeLeft = 3000; //The amount of time the projectile is alive for
            projectile.penetrate = 3; //Tells the game how many enemies it can hit before being destroyed
            projectile.friendly = true; //Tells the game whether it is friendly to players/friendly npcs or not
            projectile.hostile = false; //Tells the game whether it is hostile to players or not
            projectile.tileCollide = true; //Tells the game whether or not it can collide with a tile
            projectile.ignoreWater = true; //Tells the game whether or not projectile will be affected by water
            projectile.ranged = true; //Tells the game whether it is a ranged projectile or not
            projectile.aiStyle = 0; //How the projectile works, this is no AI, it just goes a straight path
			projectile.extraUpdates = 40;
        }
	
		 public override void AI()
		{
		projectile.rotation = projectile.velocity.ToRotation() + MathHelper.PiOver2;
		}
		
					public override Color? GetAlpha(Color lightColor)
		{
			return Color.White;
		}
		
	}
}


