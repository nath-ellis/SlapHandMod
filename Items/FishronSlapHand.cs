using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SlapHandMod.Items 
{
    public class FishronSlapHand : ModItem
    {
        public override void SetStaticDefaults()
        {
            
        }

        public override void SetDefaults()
        {
            Item.damage = 88;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 18;
            Item.useAnimation = 21;
            Item.useStyle = 1;
            Item.knockBack = 20;
            Item.value = 10000;
            Item.rare = 10;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.crit = 35;

            Item.shoot = ProjectileID.FlaironBubble;
            Item.shootSpeed = 14;
        }

        public override void AddRecipes()
        {

        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.NextBool(3))
            {
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.FishronWings);
            }
        }
    }
}
