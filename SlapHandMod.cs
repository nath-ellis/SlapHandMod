using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;

namespace SlapHandMod
{
    public class SlapHandMod : Mod
    {

    }

    public class ModGlobalNPC : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.MoonLordCore)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.MeowmereSlapHand>(), 10));
            }
            else if (npc.type == NPCID.DukeFishron)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.FishronSlapHand>(), 6));
            }
        }
    }
}
