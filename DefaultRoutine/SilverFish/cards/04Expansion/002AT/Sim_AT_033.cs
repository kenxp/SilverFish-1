using Chuck.SilverFish;
using SilverFish.Enums;

namespace SilverFish.cards._04Expansion._002AT
{
	class Sim_AT_033 : SimTemplate //* Burgle
	{
		//Add 2 random class cards to your hand (From your opponent's class).
		
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardName.unknown, ownplay, true);
            p.drawACard(CardName.unknown, ownplay, true);
        }
    }
}