using System;
using Microsoft.Xna.Framework;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ModernFirearms.Items
{
    public class Bullet762 : ModItem
    {
			public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("7.62×51mm NATO rounds");
			Tooltip.SetDefault("Box of 7.62 rounds.");
		}
        public override void SetDefaults()
        {
            item.damage = 18; //This is added with the weapon's damage
            item.ranged = true; 
            item.width = 32;
            item.height = 20;
            item.maxStack = 90;
            item.consumable = true; //Tells the game that this should be used up once fired
            item.knockBack = 1f; //Added with the weapon's knockback
            item.value = 500;
            item.rare = 2;
			item.shoot = mod.ProjectileType("SniperBullet");
            item.ammo = mod.ItemType("Bullet762"); //Tells game that the type of ammo is of ExampleBulletA

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EmptyBullet, 30);
			recipe.AddIngredient(ItemID.ExplosivePowder, 2);
            recipe.SetResult(this, 30);
            recipe.AddRecipe();
        }
    }
}