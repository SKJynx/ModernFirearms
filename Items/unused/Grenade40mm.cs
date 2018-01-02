using System;
using Microsoft.Xna.Framework;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ModernFirearms.Items
{
    public class Grenade40mm : ModItem
    {
			public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("40mm grenades");
			Tooltip.SetDefault("Box of 40mm grenades.");
		}
        public override void SetDefaults()
        {
            item.damage = 50; //This is added with the weapon's damage
            item.ranged = true; 
			item.width = 46;
			item.height = 32;
            item.maxStack = 30;
            item.consumable = true; //Tells the game that this should be used up once fired
            item.knockBack = 1f; //Added with the weapon's knockback
            item.value = 500;
            item.rare = 2;
			item.shoot = mod.ProjectileType("Grenade40mm");
            item.ammo = mod.ItemType("Grenade40mm"); //Tells game that the type of ammo is of ExampleBulletA

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EmptyBullet, 10);
			recipe.AddIngredient(ItemID.ExplosivePowder, 6);
            recipe.SetResult(this, 10);
            recipe.AddRecipe();
        }
    }
}