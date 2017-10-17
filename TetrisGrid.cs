using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

/*
 * a class for representing the Tetris playing grid
 */
class TetrisGrid
{
    Block block = new Block(0);

    public TetrisGrid(Texture2D b)
    {
        gridblock = b;
        position = Vector2.Zero;
        this.Clear();
        CreateGridArray();
        


    }

    
    int x, y;
    Color Kleur = new Color(255, 255, 255, 200);
    TetrisGrid grid;

    public void CreateGridArray()
    {
        bool[,] GridCheck = new bool[Height, Width];
        //GridCheck[1, 5] = IETS;
    }


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
    }

    /*
     * draws the grid on the screen
     */
    public void Draw(GameTime gameTime, SpriteBatch s)
    {
		Console.WriteLine(block.CreateBlock());

		for (x = 0; x < Width; x++)
        {
            for (y = 0; y < Height; y++)
            {
                s.Draw(gridblock, (position + new Vector2(x * gridblock.Width, y * gridblock.Height)), Kleur);
            }
        }
    }


}

