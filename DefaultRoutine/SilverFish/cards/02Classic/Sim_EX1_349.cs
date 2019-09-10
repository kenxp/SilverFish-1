using Chuck.SilverFish;
using SilverFish.Enums;

namespace SilverFish.cards._02Classic
{
	class Sim_EX1_349 : SimTemplate //divinefavor
	{

//    zieht so viele karten, bis ihr genauso viele karten auf eurer hand habt wie euer gegner.
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int diff = (ownplay) ? p.enemyAnzCards - p.owncards.Count :  p.owncards.Count - p.enemyAnzCards;
            if (diff >= 1)
            {
                for (int i = 0; i < diff; i++)
                {
                    //this.owncarddraw++;
                    p.drawACard(CardName.unknown, ownplay);
                }
            }
		}

	}
}