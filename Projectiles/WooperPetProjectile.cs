using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using WOOP.Players;

namespace WOOP.Projectiles
{
	public class WooperPetProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("WooperPetProjectile");
			Main.projFrames[projectile.type] = 14;
			Main.projPet[projectile.type] = true;
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.BabyGrinch);
			aiType = ProjectileID.BabyGrinch;
			projectile.height = 64;
		}

		public override bool PreAI()
		{
			Player player = Main.player[projectile.owner];
			player.grinch = false; // Relic from aiType
			return true;
		}

		public override void AI()
		{
			Player player = Main.player[projectile.owner];
			WooperPlayer modPlayer = player.GetModPlayer<WooperPlayer>();
			if (player.dead)
			{
				modPlayer.wooperPet = false;
			}
			if (modPlayer.wooperPet)
			{
				projectile.timeLeft = 2;
			}
		}
	}
}