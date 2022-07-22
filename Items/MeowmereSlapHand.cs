using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SlapHandMod.Items 
{
    public class MeowmereSlapHand : ModItem
    {
        public override void SetStaticDefaults()
        {
            
        }

        public override void SetDefaults()
        {
            Item.damage = 105;
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
            Item.crit = 34;

            Item.shoot = ProjectileID.Meowmere;
            Item.shootSpeed = 8;
        }

        public override void AddRecipes()
        {

        }
    }
}
