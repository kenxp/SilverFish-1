using System;
using System.Collections.Generic;
using System.Text;

namespace Chuck.SilverFish
{
	class Pen_NEW1_018 : PenTemplate //bloodsailraider
	{

//    kampfschrei:/ erhält angriff entsprechend dem angriff eurer waffe.
		public override int getPlayPenalty(Playfield p, Minion m, Minion target, int choice, bool isLethal)
		{
		return 0;
		}

	}
}