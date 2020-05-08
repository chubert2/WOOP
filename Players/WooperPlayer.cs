using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using static Terraria.ModLoader.ModContent;

namespace WOOP.Players
{
    class WooperPlayer : ModPlayer
    {
        public bool wooperPet;

        public override void ResetEffects()
        {
            wooperPet = false;
        }
    }
}
