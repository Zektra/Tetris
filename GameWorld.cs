using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Input;
using System;

/*
 * A class for representing the game world.
 */
class GameWorld
{
    /*
     * enum for different game states (playing or game over)
     */
    enum GameState
    {
        Playing, GameOver
    }

    /*
     * screen width and height
     */
    int screenWidth, screenHeight;

	float speed = 1000;
	float timer = 1000;

	ChooseBlock chooseBlock;
	bool Down = false;

    /*
     * random number generator
     */
    //ChooseBlock current, next;

    /*
     * main game font
     */
    SpriteFont font;

    /*
     * sprite for representing a single tetris block element
     */
    Texture2D block;

    /*
     * the current game state
     */
    GameState gameState;

	/*
	 * the block
	 */
	TetrisBlock tetromino;
    I Iblok;
    O Oblok;
    S Sblok;
    Z Zblok;
    J Jblok;
    L Lblok;
    T Tblok;

    /*
     * the main playing grid
     */
    TetrisGrid grid;

    public GameWorld(int width, int height, ContentManager Content)
    {
        screenWidth = width;
        screenHeight = height;
        //current = new ChooseBlock();
        //next = new ChooseBlock();
        gameState = GameState.Playing;
        block = Content.Load<Texture2D>("block");
        font = Content.Load<SpriteFont>("SpelFont");
        grid = new TetrisGrid(block);
        Iblok = new I(block);
        Oblok = new O(block);
        Sblok = new S(block);
        Zblok = new Z(block);
        Jblok = new J(block);
        Lblok = new L(block);
        Tblok = new T(block);
		chooseBlock = new ChooseBlock();
        tetromino = new TetrisBlock(block);
    }

    public void Reset()
    {
		grid.Clear();
    }

    public void HandleInput(GameTime gameTime, InputHelper inputHelper)
    {
        switch (chooseBlock.Current)
        {
            case 0:
                if (inputHelper.KeyPressed(Keys.W))
                {
                    
                    Iblok.Up();
                }
                if (inputHelper.KeyPressed(Keys.A))
                {
                    //tetromino.X--; // This one probably has to be changed with set
                    
                    Iblok.Left();
                }
                timer -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;
                if (timer < 0)
                {
                    Console.WriteLine("S");
                    Iblok.Down();
                    timer = (float)gameTime.ElapsedGameTime.TotalMilliseconds + speed;
                }
                if (inputHelper.KeyPressed(Keys.D))
                {
                    //tetromino.X++; // This one probably has to be changed with set
                    Console.WriteLine("D");
                    Iblok.Right();
                }
                for (int x = 0; x < Iblok.Width; x++)
                {
                    Console.WriteLine();
                    for (int y = 0; y < Iblok.Width; y++)
                    {
						if ((grid.Check(Iblok.Position.X, Iblok.Position.Y, x, y)) && (Iblok.Check(x, y) != false))
							Down = true;
                    }
                }
				if (Down)
				{
					for (int x = 0; x < Iblok.Width; x++)
					{
						Console.WriteLine();
						for (int y = 0; y < Iblok.Width; y++)
						{
							if (Iblok.Check(x, y) != false)
								grid.Place(Iblok.Position.X, Iblok.Position.Y, x, y);
						}
					}
					Iblok.Clear();
					Down = false;
					chooseBlock.genNext();
				}
                break;
            case 1:
                if (inputHelper.KeyPressed(Keys.W))
                {
                    
                    Oblok.Up();
                }
                if (inputHelper.KeyPressed(Keys.A))
                {
                    //tetromino.X--; // This one probably has to be changed with set
                    
                    Oblok.Left();
                }
                timer -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;
                if (timer < 0)
                {
                    Console.WriteLine("S");
                    Oblok.Down();
                    timer = (float)gameTime.ElapsedGameTime.TotalMilliseconds + speed;
                }
                if (inputHelper.KeyPressed(Keys.D))
                {
                    //tetromino.X++; // This one probably has to be changed with set
                    Console.WriteLine("D");
                    Oblok.Right();
                }
				for (int x = 0; x < Oblok.Width; x++)
				{
					Console.WriteLine();
					for (int y = 0; y < Oblok.Width; y++)
					{
						if ((grid.Check(Oblok.Position.X, Oblok.Position.Y, x, y)) && (Oblok.Check(x, y) != false))
							Down = true;
					}
				}
				if (Down)
				{
					for (int x = 0; x < Oblok.Width; x++)
					{
						Console.WriteLine();
						for (int y = 0; y < Oblok.Width; y++)
						{
							if (Oblok.Check(x, y) != false)
								grid.Place(Oblok.Position.X, Oblok.Position.Y, x, y);
						}
					}
					Oblok.Clear();
					Down = false;
					chooseBlock.genNext();
				}
                break;
            case 2:
                if (inputHelper.KeyPressed(Keys.W))
                {
                    
                    Tblok.Up();
                }
                if (inputHelper.KeyPressed(Keys.A))
                {
                    //tetromino.X--; // This one probably has to be changed with set
                    
                    Tblok.Left();
                }
                timer -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;
                if (timer < 0)
                {
                    Console.WriteLine("S");
                    Tblok.Down();
                    timer = (float)gameTime.ElapsedGameTime.TotalMilliseconds + speed;
                }
                if (inputHelper.KeyPressed(Keys.D))
                {
                    //tetromino.X++; // This one probably has to be changed with set
                    Console.WriteLine("D");
                    Tblok.Right();
                }
				for (int x = 0; x < Tblok.Width; x++)
				{
					Console.WriteLine();
					for (int y = 0; y < Tblok.Width; y++)
					{
						if ((grid.Check(Tblok.Position.X, Tblok.Position.Y, x, y)) && (Tblok.Check(x, y) != false))
							Down = true;
					}
				}
				if (Down)
				{
					for (int x = 0; x < Tblok.Width; x++)
					{
						Console.WriteLine();
						for (int y = 0; y < Tblok.Width; y++)
						{
							if (Tblok.Check(x, y) != false)
								grid.Place(Tblok.Position.X, Tblok.Position.Y, x, y);
						}
					}
					Tblok.Clear();
					Down = false;
					chooseBlock.genNext();
				}
                break;
            case 3:
                if (inputHelper.KeyPressed(Keys.W))
                {
                    
                    Sblok.Up();
                }
                if (inputHelper.KeyPressed(Keys.A))
                {
                    //tetromino.X--; // This one probably has to be changed with set
                    
                    Sblok.Left();
                }
                timer -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;
                if (timer < 0)
                {
                    Console.WriteLine("S");
                    Sblok.Down();
                    timer = (float)gameTime.ElapsedGameTime.TotalMilliseconds + speed;
                }
                if (inputHelper.KeyPressed(Keys.D))
                {
                    //tetromino.X++; // This one probably has to be changed with set
                    Console.WriteLine("D");
                    Sblok.Right();
                }
				for (int x = 0; x < Sblok.Width; x++)
				{
					Console.WriteLine();
					for (int y = 0; y < Sblok.Width; y++)
					{
						if ((grid.Check(Sblok.Position.X, Sblok.Position.Y, x, y)) && (Sblok.Check(x, y) != false))
							Down = true;
					}
				}
				if (Down)
				{
					for (int x = 0; x < Sblok.Width; x++)
					{
						Console.WriteLine();
						for (int y = 0; y < Sblok.Width; y++)
						{
							if (Sblok.Check(x, y) != false)
								grid.Place(Sblok.Position.X, Sblok.Position.Y, x, y);
						}
					}
					Sblok.Clear();
					Down = false;
					chooseBlock.genNext();
				}
                break;
            case 4:
                if (inputHelper.KeyPressed(Keys.W))
                {
                    
                    Zblok.Up();
                }
                if (inputHelper.KeyPressed(Keys.A))
                {
                    //tetromino.X--; // This one probably has to be changed with set
                    
                    Zblok.Left();
                }
                timer -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;
                if (timer < 0)
                {
                    Console.WriteLine("S");
                    Zblok.Down();
                    timer = (float)gameTime.ElapsedGameTime.TotalMilliseconds + speed;
                }
                if (inputHelper.KeyPressed(Keys.D))
                {
                    //tetromino.X++; // This one probably has to be changed with set
                    Console.WriteLine("D");
                    Zblok.Right();
                }
				for (int x = 0; x < Zblok.Width; x++)
				{
					Console.WriteLine();
					for (int y = 0; y < Zblok.Width; y++)
					{
						if ((grid.Check(Zblok.Position.X, Zblok.Position.Y, x, y)) && (Zblok.Check(x, y) != false))
							Down = true;
					}
				}
				if (Down)
				{
					for (int x = 0; x < Zblok.Width; x++)
					{
						Console.WriteLine();
						for (int y = 0; y < Zblok.Width; y++)
						{
							if (Zblok.Check(x, y) != false)
								grid.Place(Zblok.Position.X, Zblok.Position.Y, x, y);
						}
					}
					Zblok.Clear();
					Down = false;
					chooseBlock.genNext();
				}
                break;
            case 5:
                if (inputHelper.KeyPressed(Keys.W))
                {
                    
                    Jblok.Up();
                }
                if (inputHelper.KeyPressed(Keys.A))
                {
                    //tetromino.X--; // This one probably has to be changed with set
                    
                    Jblok.Left();
                }
                timer -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;
                if (timer < 0)
                {
                    Console.WriteLine("S");
                    Jblok.Down();
                    timer = (float)gameTime.ElapsedGameTime.TotalMilliseconds + speed;
                }
                if (inputHelper.KeyPressed(Keys.D))
                {
                    //tetromino.X++; // This one probably has to be changed with set
                    Console.WriteLine("D");
                    Jblok.Right();
                }
				for (int x = 0; x < Jblok.Width; x++)
				{
					Console.WriteLine();
					for (int y = 0; y < Jblok.Width; y++)
					{
						if ((grid.Check(Jblok.Position.X, Jblok.Position.Y, x, y)) && (Jblok.Check(x, y) != false))
							Down = true;
					}
				}
				if (Down)
				{
					for (int x = 0; x < Jblok.Width; x++)
					{
						Console.WriteLine();
						for (int y = 0; y < Jblok.Width; y++)
						{
							if (Jblok.Check(x, y) != false)
								grid.Place(Jblok.Position.X, Jblok.Position.Y, x, y);
						}
					}
					Jblok.Clear();
					Down = false;
					chooseBlock.genNext();
				}
                break;
            case 6:
                if (inputHelper.KeyPressed(Keys.W))
                {
                    
                    Lblok.Up();
                }
                if (inputHelper.KeyPressed(Keys.A))
                {
                    //tetromino.X--; // This one probably has to be changed with set
                    
                    Lblok.Left();
                }
                timer -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;
                if (timer < 0)
                {
                    Console.WriteLine("S");
                    Lblok.Down();
                    timer = (float)gameTime.ElapsedGameTime.TotalMilliseconds + speed;
                }
                if (inputHelper.KeyPressed(Keys.D))
                {
                    //tetromino.X++; // This one probably has to be changed with set
                    Console.WriteLine("D");
                    Lblok.Right();
                }
				for (int x = 0; x < Lblok.Width; x++)
				{
					Console.WriteLine();
					for (int y = 0; y < Lblok.Width; y++)
					{
						if ((grid.Check(Lblok.Position.X, Lblok.Position.Y, x, y)) && (Lblok.Check(x, y) != false))
							Down = true;
					}
				}
				if (Down)
				{
					for (int x = 0; x < Lblok.Width; x++)
					{
						Console.WriteLine();
						for (int y = 0; y < Lblok.Width; y++)
						{
							if (Lblok.Check(x, y) != false)
								grid.Place(Lblok.Position.X, Lblok.Position.Y, x, y);
						}
					}
					Lblok.Clear();
					Down = false;
					chooseBlock.genNext();
				}
                break;
        }

    }

    public void Update(GameTime gameTime)
    {
        
    }

    public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {

        spriteBatch.Begin();
		grid.Draw(gameTime, spriteBatch);
		switch (chooseBlock.Current)
		{
			case 0:
				Iblok.Draw(gameTime, spriteBatch);
				break;
			case 1:
				Oblok.Draw(gameTime, spriteBatch);
				break;
			case 2:
				Tblok.Draw(gameTime, spriteBatch);
				break;
			case 3:
				Sblok.Draw(gameTime, spriteBatch);
				break;
			case 4:
				Zblok.Draw(gameTime, spriteBatch);
				break;
			case 5:
				Jblok.Draw(gameTime, spriteBatch);
				break;
			case 6:
				Lblok.Draw(gameTime, spriteBatch);
				break;
		}
        DrawText("Hello!", Vector2.Zero, spriteBatch);
        spriteBatch.End();
    }

    /*
     * utility method for drawing text on the screen
     */
    public void DrawText(string text, Vector2 positie, SpriteBatch spriteBatch)
    {
        spriteBatch.DrawString(font, text, positie, Color.Blue);
    }


}
