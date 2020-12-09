using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Chess_Board
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Rectangle[] blackPieceRectangle = new Rectangle[6];
        Rectangle[] whitePieceRectangle = new Rectangle[6];
        Rectangle boardRtc;

        Texture2D[] blackPieceTexture = new Texture2D[6];
        Texture2D[] whitePieceTexture = new Texture2D[6];
        Texture2D boardRectangle;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferHeight = 530;
            graphics.PreferredBackBufferWidth = 500;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            this.IsMouseVisible = true;
            // TODO: Add your initialization logic here
            boardRtc = new Rectangle(0, 0, 500, 530);

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            for (int i = 0; i < 6; i++)
            {
                blackPieceTexture[i] = this.Content.Load<Texture2D>("Black" + (i + 1));
            }
            for (int i = 0; i < 6; i++)
            {
                whitePieceTexture[i] = this.Content.Load<Texture2D>("White" + (i + 1));
            }
            boardRectangle = this.Content.Load<Texture2D>("Board");
        }



        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            KeyboardState kb = Keyboard.GetState();
            if (kb.IsKeyDown(Keys.Escape))
                this.Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            // TODO: Add your drawing code here
            spriteBatch.Draw(boardRectangle, boardRtc, Color.White);

            for (int i = 0; i < 3; i++)
            {
                blackPieceRectangle[i] = new Rectangle((i * 61) + 10, 14, 50, 50);
                spriteBatch.Draw(blackPieceTexture[i], blackPieceRectangle[i], Color.White);
            }
            blackPieceRectangle[3] = new Rectangle(193, 14, 50, 50);
            spriteBatch.Draw(blackPieceTexture[3], blackPieceRectangle[3], Color.White);
            blackPieceRectangle[4] = new Rectangle(255, 14, 50, 50);
            spriteBatch.Draw(blackPieceTexture[4], blackPieceRectangle[4], Color.White);
            for (int i = 0; i < 3; i++)
            {
                blackPieceRectangle[i] = new Rectangle((i * 61) + 318, 14, 50, 50);
                spriteBatch.Draw(blackPieceTexture[2 - i], blackPieceRectangle[i], Color.White);
            }
            for (int i = 0; i < 8; i++)
            {
                blackPieceRectangle[5] = new Rectangle((i * 61) + 10, 79, 50, 50);
                spriteBatch.Draw(blackPieceTexture[5], blackPieceRectangle[5], Color.White);
            }

            for (int i = 0; i < 3; i++)
            {
                whitePieceRectangle[i] = new Rectangle((i * 61) + 10, 477, 50, 50);
                spriteBatch.Draw(whitePieceTexture[i], whitePieceRectangle[i], Color.White);
            }
            whitePieceRectangle[3] = new Rectangle(193, 477, 50, 50);
            spriteBatch.Draw(whitePieceTexture[3], whitePieceRectangle[3], Color.White);
            whitePieceRectangle[4] = new Rectangle(255, 477, 50, 50);
            spriteBatch.Draw(whitePieceTexture[4], whitePieceRectangle[4], Color.White);
            for (int i = 0; i < 3; i++)
            {
                whitePieceRectangle[i] = new Rectangle((i * 61) + 318, 477, 50, 50);
                spriteBatch.Draw(whitePieceTexture[2 - i], whitePieceRectangle[i], Color.White);
            }
            for (int i = 0; i < 8; i++)
            {
                whitePieceRectangle[5] = new Rectangle((i * 61) + 10, 410, 50, 50);
                spriteBatch.Draw(whitePieceTexture[5], whitePieceRectangle[5], Color.White);
            }

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
