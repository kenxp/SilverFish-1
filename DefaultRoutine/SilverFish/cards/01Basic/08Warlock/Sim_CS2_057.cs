using Chuck.SilverFish;

namespace SilverFish.cards._01Basic._08Warlock
{
	class Sim_CS2_057 : SimTemplate //shadowbolt
	{

//    fügt einem diener $4 schaden zu.
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
            p.minionGetDamageOrHeal(target, dmg);
		}

	}
}