#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using NetherTear.Resources;
using NetherTear.Framework.Engine;
using NetherTear.MonoGame.EventHandlers;
using NetherTear.MonoGame.Renderers;
using NetherTear.Framework.Config;
using NetherTear.Framework.GameObjects;
#endregion

namespace NetherTear.MonoGame
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class NetherTearGame : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Engine engine;
        GameRenderer renderer;
        UserInputHandler input;
        Dictionary<string, Texture2D> textures = new Dictionary<string,Texture2D>();
        Dictionary<string, SpriteFont> spriteFonts = new Dictionary<string, SpriteFont>();

        public NetherTearGame()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.IsFullScreen = false;
            graphics.PreferredBackBufferWidth = GraphicsConfig.DefaultWidth;
            graphics.PreferredBackBufferHeight = GraphicsConfig.DefaultHeight;
            renderer = new GameRenderer(graphics);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            engine = new Engine();
            renderer.GameState = engine.GameState;
            renderer.Initialize();
            input = new UserInputHandler(engine.GameState);
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
            textures.Add("Player", Content.Load<Texture2D>(ObjectImages.PlayerImagePath));
            textures.Add("Tree", Content.Load<Texture2D>(ObjectImages.TreeImagePath));
            textures.Add("Grass", Content.Load<Texture2D>(ObjectImages.BackgroundGrassPath));
            textures.Add("Grass", Content.Load<Texture2D>(ObjectImages.Ground1Path));
            spriteFonts.Add("Default", Content.Load<SpriteFont>("SpriteFonts/Default"));
            renderer.SpriteBatch = spriteBatch;
            renderer.Textures = textures;
            renderer.SpriteFonts = spriteFonts;
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            input.HandleUserInput();
            engine.Update();

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            renderer.Draw();
            base.Draw(gameTime);
        }
    }
}
