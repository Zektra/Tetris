using System;

	public class ChooseBlock
	{
		int first, second;
		Random r = new Random();
		public void genFirst()
		{
			first = r.Next(0, 6);
			second = r.Next(0, 6);
		}
		public void genNext()
		{
			first = second;
			second = r.Next(0, 6);
		}
		public int Current
		{
			get { return first; }
		}
		public int Next
		{
			get { return second; }
		}
	}
