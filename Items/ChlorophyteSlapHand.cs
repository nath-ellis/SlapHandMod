using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace SlapHandMod.Items 
{
    public class ChlorophyteSlapHand : ModItem
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
            Item.rare = 7;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.crit = 30;

            Item.shoot = ProjectileID.SporeCloud;
            Item.shootSpeed = 8;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.ChlorophyteBar, 12);
            recipe.AddIngredient(ItemID.SlapHand, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}
