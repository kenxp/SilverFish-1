using System;
using System.Collections.Generic;
using System.Text;

namespace Chuck.SilverFish
{
	class Pen_EX1_048 : PenTemplate //spellbreaker
	{

//    kampfschrei:/ bringt einen diener zum schweigen/.
		public override int getPlayPenalty(Playfield p, Minion m, Minion target, int choice, bool isLethal)
		{
		return 0;
		}

	}
}