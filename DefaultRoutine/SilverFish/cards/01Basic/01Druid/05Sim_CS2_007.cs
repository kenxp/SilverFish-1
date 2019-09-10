using Chuck.SilverFish;

namespace SilverFish.cards._01Basic._01Druid
{
	class Sim_CS2_007 : SimTemplate //healingtouch
	{

//    stellt #8 leben wieder her.

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int heal = (ownplay) ? p.getSpellHeal(8) : p.getEnemySpellHeal(8);
            p.minionGetDamageOrHeal(target, -heal);
            
		}

	}
}