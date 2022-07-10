using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SlapHandMod.Items 
{
    public class MythrilSlapHand : ModItem
    {
        public override void SetStaticDefaults()
        {
            
        }

        public override void SetDefaults()
        {
            Item.damage = 46;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 21;
            Item.useAnimation = 21;
            Item.useStyle = 1;
            Item.knockBack = 20;
            Item.value = 10000;
            Item.rare = 4;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.crit = 20;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.MythrilBar, 10);
            recipe.AddIngredient(ItemID.SlapHand, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}
