using System;
using Microsoft.Xna.Framework;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ModernFirearms.Items
{
    public class Bullet3006 : ModItem
    {
			public override void SetStaticDefaults()
		{
			DisplayName.SetDefault(".30-06 rounds");
			Tooltip.SetDefault("Box of .30-06 rounds.");
		}
        public override void SetDefaults()
        {
            item.damage = 18; //This is added with the weapon's damage
            item.ranged = true; 
            item.width = 32;
            item.height = 20;
            item.maxStack = 150;
            item.consumable = true; //Tells the game that this should be used up once fired
            item.knockBack = 1f; //Added with the weapon's knockback
            item.value = 500;
            item.rare = 2;
			item.shoot = mod.ProjectileType("CarbineBullet");
            item.ammo = mod.ItemType("Bullet3006"); //Tells game that the type of ammo is of ExampleBulletA

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EmptyBullet, 50);
			recipe.AddIngredient(ItemID.ExplosivePowder, 2);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }
}