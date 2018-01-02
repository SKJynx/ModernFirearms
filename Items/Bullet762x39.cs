using System;
using Microsoft.Xna.Framework;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ModernFirearms.Items
{
    public class Bullet762x39 : ModItem
    {
			public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("7.62×39mm rounds");
			Tooltip.SetDefault("Box of 7.62x39 rounds");
		}
        public override void SetDefaults()
        {
            item.damage = 11; //This is added with the weapon's damage
            item.ranged = true; 
            item.width = 32;
            item.height = 20;
            item.maxStack = 300;
            item.consumable = true; //Tells the game that this should be used up once fired
            item.knockBack = 1f; //Added with the weapon's knockback
            item.value = 500;
            item.rare = 2;
			item.shoot = mod.ProjectileType("Bullet");
            item.ammo = mod.ItemType("Bullet762x39"); //Tells game that the type of ammo is of ExampleBulletA

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EmptyBullet, 60);
			recipe.AddIngredient(ItemID.ExplosivePowder, 2);
            recipe.SetResult(this, 60);
            recipe.AddRecipe();
        }
    }
}