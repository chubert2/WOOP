using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using WOOP.Players;
using WOOP.Projectiles;

namespace WOOP.Buffs
{
    class WooperPetBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Pet Wooper");
            Description.SetDefault("Woop woop");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<WooperPlayer>().wooperPet = true;
            bool petProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("WooperPetProjectile")] <= 0;
            if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("WooperPetProjectile"), 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }
}
