using Chuck.SilverFish;

namespace SilverFish.cards._01Basic._05Priest
{
	class Sim_CS1_129 : SimTemplate //innerfire
	{

//    setzt den angriff eines dieners auf einen wert, der seinem leben entspricht.
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.minionSetAngrToHP(target);
		}

	}
}