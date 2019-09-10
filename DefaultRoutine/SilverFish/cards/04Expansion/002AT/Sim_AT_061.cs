using Chuck.SilverFish;

namespace SilverFish.cards._04Expansion._002AT
{
	class Sim_AT_061 : SimTemplate //* Lock and Load
	{
		//Each time you cast a spell this turn, add a random Hunter card to your hand.
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{			
            if (ownplay)
            {
                p.lockandload++;
            }
		}
	}
}