using System;
using Microsoft.Xna.Framework;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ModernFirearms.Items
{
	public class AmmoCrate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ammo crate");
			Tooltip.SetDefault("<right> for ammo. (debut purposes)");
		}

		public override void SetDefaults()
		{
			item.width = 46;
			item.height = 32;
			item.rare = 2;
			item.maxStack = 99;
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
			player.QuickSpawnItem(ModLoader.GetMod("ModernFirearms").ItemType("Bullet9mm"), 600);
			player.QuickSpawnItem(ModLoader.GetMod("ModernFirearms").ItemType("Shotshells12g"), 80);
			player.QuickSpawnItem(ModLoader.GetMod("ModernFirearms").ItemType("Bullet45ACP"), 400);
			player.QuickSpawnItem(ModLoader.GetMod("ModernFirearms").ItemType("Bullet50AE"), 100);
			player.QuickSpawnItem(ModLoader.GetMod("ModernFirearms").ItemType("Bullet500"), 72);
			player.QuickSpawnItem(ModLoader.GetMod("ModernFirearms").ItemType("Bullet556"), 600);
			player.QuickSpawnItem(ModLoader.GetMod("ModernFirearms").ItemType("Bullet762x39"), 400);
			player.QuickSpawnItem(ModLoader.GetMod("ModernFirearms").ItemType("Bullet762x51"), 90);
			player.QuickSpawnItem(ModLoader.GetMod("ModernFirearms").ItemType("Bullet3006"), 150);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}