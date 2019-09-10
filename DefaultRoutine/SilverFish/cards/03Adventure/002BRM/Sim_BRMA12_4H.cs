using Chuck.SilverFish;

namespace SilverFish.cards._03Adventure._002BRM
{
	class Sim_BRMA12_4H : SimTemplate //* Brood Affliction: Green
	{
		//While this is in your hand, restore 6 health to your opponent at the start of your turn.

        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (triggerEffectMinion.own == turnStartOfOwner)
            {
                p.minionGetDamageOrHeal(turnStartOfOwner ? p.ownHero : p.enemyHero, -6, true);
            }
        }
    }
}