using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

/*
 * a class for representing the Tetris playing grid
 */
class TetrisGrid
{
	public TetrisGrid(Texture2D b)
	{
		gridblock = b;
		position = Vector2.Zero;
		this.Clear();
	}

	bool[,] TGrid;

	/*
     * sprite for representing a single grid block
     */
    Texture2D gridblock;

    /*
     * the position of the tetris grid
     */
    Vector2 position;

    /*
     * width in terms of grid elements
     */
    public int Width
    {
        get { return 12; }
    }

    /*
     * height in terms of grid elements
     */
    public int Height
    {
        get { return 20; }
    }

    /*
     * clears the grid
     */
    public void Clear()
    {
		TGrid = new bool[Width, Height];;
		Console.WriteLine("Reset");
		TGrid[2, 5] = true;
    }

	public bool Check(float tposx, float tposy, int x, int y)
    {
        return TGrid[(int)tposx / gridblock.Width + y, (int)tposy / gridblock.Width + x];
    }
	/*
     * draws the grid on the screen
     */
	public void Draw(GameTime gameTime, SpriteBatch s)
	{
		for (int x = 0; x < Width; x++)
		{
			for (int y = 0; y < Height; y++)
			{
				if (TGrid[x, y])
					s.Draw(gridblock, (position + new Vector2(x * gridblock.Width, y * gridblock.Height)), Color.Green);
				else
					s.Draw(gridblock, (position + new Vector2(x * gridblock.Width, y * gridblock.Height)), Color.White);
			}
		}
	}
}

