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

namespace Defender
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D  baiterTex, baiter1Tex, baiter2Tex, baiter3Tex, baiter4Tex, baiter5Tex, baiter6Tex, baiter7Tex,
                   bomberTex, bomber1Tex, bomber2Tex, bomber3Tex, bomber4Tex,
                   humanTex,
                   landerTex, lander1Tex, lander2Tex, lander3Tex, lander4Tex,
                   muntantTex,
                   podTex,
                   shipTex, shipLeftTex, shipRightTex,
                   swarmerTex;
        Rectangle baiterRec, bomberRec, humanRec, landerRec, mutantRec, podRec, shipRec, swarmerRec;
        int timer = 0;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
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
            // TODO: Add your initialization logic here
            baiterRec = new Rectangle(10, 10, 26, 10);
            bomberRec = new Rectangle(46, 10, 16, 16);
            humanRec = new Rectangle(72, 10, 12, 18);
            landerRec = new Rectangle(94, 10, 22, 18);
            mutantRec = new Rectangle(126, 10, 22, 17);
            podRec = new Rectangle(158, 10, 16, 16);
            shipRec = new Rectangle(184, 10, 35, 16);
            swarmerRec = new Rectangle(229, 10, 14, 14);
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
            baiterTex = Content.Load<Texture2D>("Baiter1");
            baiter1Tex = Content.Load<Texture2D>("Baiter1");
            baiter2Tex = Content.Load<Texture2D>("Baiter2");
            baiter3Tex = Content.Load<Texture2D>("Baiter3");
            baiter4Tex = Content.Load<Texture2D>("Baiter4");
            baiter5Tex = Content.Load<Texture2D>("Baiter5");
            baiter6Tex = Content.Load<Texture2D>("Baiter6");
            baiter7Tex = Content.Load<Texture2D>("Baiter7");
            bomberTex = Content.Load<Texture2D>("Bomber1");
            bomber1Tex = Content.Load<Texture2D>("Bomber1");
            bomber2Tex = Content.Load<Texture2D>("Bomber2");
            bomber3Tex = Content.Load<Texture2D>("Bomber3");
            bomber4Tex = Content.Load<Texture2D>("Bomber4");
            humanTex = Content.Load<Texture2D>("Human1");
            landerTex = Content.Load<Texture2D>("LanderLeft1");
            lander1Tex = Content.Load<Texture2D>("LanderLeft1");
            lander2Tex = Content.Load<Texture2D>("LanderLeft2");
            lander3Tex = Content.Load<Texture2D>("LanderRight1");
            lander4Tex = Content.Load<Texture2D>("LanderRight2");
            muntantTex = Content.Load<Texture2D>("Mutant");
            podTex = Content.Load<Texture2D>("Pod");
            shipLeftTex = Content.Load<Texture2D>("ShipLeft");
            shipRightTex = Content.Load<Texture2D>("ShipRight");
            swarmerTex = Content.Load<Texture2D>("Swarmer");
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
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here
            timer = (timer + 1) % 60;

            if (timer < 9)
                baiterTex = baiter1Tex;
            else if (timer < 18)
                baiterTex = baiter2Tex;
            else if (timer < 26)
                baiterTex = baiter3Tex;
            else if (timer < 35)
                baiterTex = baiter4Tex;
            else if (timer < 43)
                baiterTex = baiter5Tex;
            else if (timer < 52)
                baiterTex = baiter6Tex;
            else if (timer < 60)
                baiterTex = baiter7Tex;

            if (timer < 10)
                landerTex = lander4Tex;
            else if (timer < 20)
                landerTex = lander3Tex;
            else if (timer < 30)
                landerTex = lander1Tex;
            else if (timer < 40)
                landerTex = lander2Tex;
            else if (timer < 50)
                landerTex = lander1Tex;
            else if (timer < 60)
                landerTex = lander3Tex;

            if (timer < 10)
                bomberTex = bomber1Tex;
            else if (timer < 20)
                bomberTex = bomber2Tex;
            else if (timer < 30)
                bomberTex = bomber3Tex;
            else if (timer < 40)
                bomberTex = bomber4Tex;
            else if (timer < 50)
                bomberTex = bomber3Tex;
            else if (timer < 60)
                bomberTex = bomber2Tex;

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            spriteBatch.Draw(baiterTex, baiterRec, Color.White);
            spriteBatch.Draw(bomberTex, bomberRec, Color.White);
            spriteBatch.Draw(humanTex, humanRec, Color.White);
            spriteBatch.Draw(landerTex, landerRec, Color.White);
            spriteBatch.Draw(muntantTex, mutantRec, Color.White);
            spriteBatch.Draw(podTex, podRec, Color.White);
            spriteBatch.Draw(shipTex, shipRec, Color.White);
            spriteBatch.Draw(swarmerTex, swarmerRec, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
