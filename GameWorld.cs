﻿using Microsoft.Xna.Framework;
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

    /*
     * random number generator
     */
    Random random;

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

    /*
     * the main playing grid
     */
    TetrisGrid grid;

    public GameWorld(int width, int height, ContentManager Content)
    {
        screenWidth = width;
        screenHeight = height;
        random = new Random();
        gameState = GameState.Playing;

        block = Content.Load<Texture2D>("block");
        font = Content.Load<SpriteFont>("SpelFont");
        grid = new TetrisGrid(block);
		tetromino = new TetrisBlock();
    }

    public void Reset()
    {
		grid.Clear();
    }

    public void HandleInput(GameTime gameTime, InputHelper inputHelper)
    {
		if (inputHelper.KeyPressed(Keys.W))
		{
			Console.WriteLine("W");
		}
		if (inputHelper.KeyPressed(Keys.A) && tetromino.X - 1 != 0)
		{
			//tetromino.X--; // This one probably has to be changed with set
			Console.WriteLine("A");
		}
		if (inputHelper.KeyPressed(Keys.S))
		{
			Console.WriteLine("S");
		}
		if (inputHelper.KeyPressed(Keys.D) && tetromino.X + 1 != grid.Width)
		{
			//tetromino.X++; // This one probably has to be changed with set
			Console.WriteLine("D");
		}
    }

    public void Update(GameTime gameTime)
    {
    }

    public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
        spriteBatch.Begin();
        grid.Draw(gameTime, spriteBatch);
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

    public Random Random
    {
        get { return random; }
    }
}
