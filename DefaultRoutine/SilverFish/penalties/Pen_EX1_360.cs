using System;
using System.Collections.Generic;
using System.Text;

namespace Chuck.SilverFish
{
	class Pen_EX1_360 : PenTemplate //humility
	{

//    setzt den angriff eines dieners auf 1.
		public override int getPlayPenalty(Playfield p, Minion m, Minion target, int choice, bool isLethal)
		{
		return 0;
		}

	}
}