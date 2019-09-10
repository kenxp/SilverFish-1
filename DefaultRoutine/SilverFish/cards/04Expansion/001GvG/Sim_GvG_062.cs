using Chuck.SilverFish;

namespace SilverFish.cards._04Expansion._001GvG
{
    class Sim_GVG_062 : SimTemplate //Cobalt Guardian
    {

        //   Whenever you summon a Mech, gain Divine Shield.

        public override void onMinionIsSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
        {
            if (triggerEffectMinion.own==summonedMinion.own && (TAG_RACE)summonedMinion.handcard.card.race == TAG_RACE.MECHANICAL)
            {
                triggerEffectMinion.DivineShield = true;
            }
        }



    }

}