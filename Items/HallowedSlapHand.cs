using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SlapHandMod.Items 
{
    public class HallowedSlapHand : ModItem
    {
        public override void SetStaticDefaults()
        {
            
        }

        public override void SetDefaults()
        {
            Item.damage = 63;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 21;
            Item.useAnimation = 21;
            Item.useStyle = 1;
            Item.knockBack = 20;
            Item.value = 10000;
            Item.rare = 5;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.crit = 28;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.HallowedBar, 12);
            recipe.AddIngredient(ItemID.SlapHand, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.NextBool(3))
            {
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.HallowedWeapons);
            }
        }
    }
}
