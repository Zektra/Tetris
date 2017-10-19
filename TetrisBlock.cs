using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

/*
 * a class for representing the Tetris playing grid
 */
class TetrisBlock
{
    public TetrisBlock(Texture2D b)
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
     * Position of block
     */
    public Vector2 Position
    {
        get { return position; }
    }

    /*
     * width in terms of grid elements
     */
    public int Width
    {
        get { return 4; }
    }

    /*
     * height in terms of grid elements
     */
    public int Height
    {
        get { return 4; }
    }

    /*
     * clears the grid
     */
    public void Clear()
    {
        TGrid = new bool[Width, Height];
        Console.WriteLine("Reset");
		TGrid[1, 2] = true;
		TGrid[0, 3] = true;
		TGrid[1, 3] = true;
		TGrid[2, 3] = true;
    }

	/*
	 * Returns boolean of position in TGrid
	 */
	public bool Check(int x, int y)
	{
		return TGrid[y, x];
    }

    public void Down()
    {
        position = position + new Vector2(0, 1 * gridblock.Width);
    }
    public void Up()
    {
        position = position - new Vector2(0, 1 * gridblock.Width);
    }
    public void Left()
    {
        if (position.X > 0)
            position = position - new Vector2(1 * gridblock.Width, 0);
    }
    public void Right()
    {
        if (position.X + gridblock.Width < 9 * gridblock.Width)
            position = position + new Vector2(1 * gridblock.Width, 0);
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
					s.Draw(gridblock, (position + new Vector2(x * gridblock.Width, y * gridblock.Height)), Color.Blue);
            }
        }
    }
}