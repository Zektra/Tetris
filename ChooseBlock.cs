using System;
namespace Tetris
{
	public class ChooseBlock
	{
		Random r = new Random();
		public void genNext()
		{
			int first = r.Next(0, 6);
			int second = r.Next(0, 6);
		}
		public int first
		{
			get { return first; }
		}
		public int second
		{
			get { return second; }
		}
	}
}