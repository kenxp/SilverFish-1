using Chuck.SilverFish;

namespace SilverFish.cards._01Basic._08Warlock
{
	class Sim_CS2_062 : SimTemplate //hellfire
	{

//    fügt allen charakteren $3 schaden zu.
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
            p.allCharsGetDamage(dmg);
		}

	}
}