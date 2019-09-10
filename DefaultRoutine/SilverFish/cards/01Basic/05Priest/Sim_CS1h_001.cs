using Chuck.SilverFish;

namespace SilverFish.cards._01Basic._05Priest
{
	class Sim_CS1h_001 : SimTemplate //lesserheal
	{

//    heldenfähigkeit/\nstellt 2 leben wieder her.

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int heal = 2;
            if (ownplay)
            {
                if (p.anzOwnAuchenaiSoulpriest > 0 || p.embracetheshadow > 0) heal = -heal;
                if (p.doublepriest >= 1) heal *= (2 * p.doublepriest);
            }
            else
            {
                if (p.anzEnemyAuchenaiSoulpriest >= 1) heal = -heal;
                if (p.enemydoublepriest >= 1) heal *= (2 * p.enemydoublepriest);
            }
            p.minionGetDamageOrHeal(target, -heal);
            
            
		}

	}
}