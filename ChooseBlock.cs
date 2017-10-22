using System;
namespace Tetris
{
	public class ChooseBlock
	{
		Random r;

		public ChooseBlock()
		{
			r = new Random();
		}
		public int random()
		{
			int rand = r.Next();
			return rand;
		}
	}
}