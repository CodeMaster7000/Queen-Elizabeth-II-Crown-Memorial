using System;
class GFG {
	static void crown(int length, int height)
	{
		for (int i = 0; i < height; i++)
		{
			for (int j = 0; j < length; j++)
			{
				if (i == 0)
				{
					if (j == 0 || j == height
							|| j == length - 1)
					{
						Console.Write("*");
					}
					else {
						Console.Write(" ");
					}
				}
        
				else if (i == height - 1)
				{
					Console.Write("*");
				}
        
				else if ((j < i || j > height - i) &&
								(j < height + i ||
								j >= length - i))
					Console.Write("#");
				else
					Console.Write(" ");
			}
			
			Console.WriteLine();
		}
	}
	public static void Main ()
	{
		int length = 25;
		int height = (length - 1) / 2;
		crown(length, height);				
	}
}
