using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using WOOP.Projectiles;
using WOOP.Buffs;

namespace WOOP.Items
{
	public class WooperPet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Purple Gills");
			Tooltip.SetDefault("Summons a Wooper");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.BabyGrinchMischiefWhistle);
			item.shoot = mod.ProjectileType("WooperPetProjectile");
			item.buffType = mod.BuffType("WooperPetBuff");
			item.rare = 6;
		}

		public override void UseStyle(Player player)
		{
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
			{
				player.AddBuff(item.buffType, 3600, true);
			}
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PurpleMucos, 4);
			recipe.AddIngredient(ItemID.Gel, 99);
			recipe.AddIngredient(ItemID.JungleSpores, 15);
			recipe.AddTile(TileID.ImbuingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}