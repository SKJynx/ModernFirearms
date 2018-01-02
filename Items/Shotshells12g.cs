using System;
using Microsoft.Xna.Framework;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ModernFirearms.Items
{
    public class Shotshells12g : ModItem
    {
			public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("12 gauge shells");
			Tooltip.SetDefault("Box of 12 gauge shotgun shells.");
		}
        public override void SetDefaults()
        {
            item.damage = 5; //This is added with the weapon's damage
            item.ranged = true; 
            item.width = 32;
            item.height = 20;
            item.maxStack = 80;
            item.consumable = true; //Tells the game that this should be used up once fired
            item.knockBack = 1f; //Added with the weapon's knockback
            item.value = 500;
            item.rare = 2;
			item.shoot = mod.ProjectileType("Pellet");
            item.ammo = mod.ItemType("Shotshells12g"); //Tells game that the type of ammo is of ExampleBulletA

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EmptyBullet, 20);
			recipe.AddIngredient(ItemID.ExplosivePowder, 2);
            recipe.SetResult(this, 20);
            recipe.AddRecipe();
        }
    }
}