/*
 * 
 * proyecto.....: HelloWorldXNA
 * herramienta..: VS C# 2008 Espress Edition
 * fecha........: 22-05-2016
 * Referencia...: x CDOK x BaDz [usuario YouTube.com]. "XNA 4.0 Part 1 (How to add texture's/sprite's and add text)".
 *   https://youtu.be/LvsnH-_VKco (consultada el 22-05-2016).
 * 
 */

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
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;

namespace HelloWorldXNA
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        //*********************************************************************
        //********************** Inicio: código agregado **********************
        //********************** 1a Modificación         **********************
        Texture2D miOso, miguitarraGarageband;
        SpriteFont miFuente;
        string miTexto;
        Vector2 posicionMiOso, posicionGuitarraGarageband, posicionMiTexto;
        //**********************   Fin: código agregado  **********************
        //*********************************************************************

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            // Change resolution to 800 by 600
            graphics.PreferredBackBufferWidth  = 800;
            graphics.PreferredBackBufferHeight = 600;
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
            
            // Load teddy bears and build draw rectangles
            //bear0 = Content.Load<Texture2D>(@"graphics\balalaika");
            //*********************************************************************
            //********************** Inicio: código agregado **********************
            //********************** 2a Modificación         **********************
            miOso = Content.Load<Texture2D>(@"graphics\osito_cafe");
            posicionMiOso = new Vector2(50, 50);
            
            miguitarraGarageband = Content.Load<Texture2D>(@"graphics\guitarra_garageband");
            posicionGuitarraGarageband = new Vector2(200, 250);

            miFuente = Content.Load<SpriteFont>(@"graphics\SpriteFont1");
            posicionMiTexto = new Vector2(10, 10);
            miTexto = "Hola Mundo!";
            //**********************   Fin: código agregado  **********************
            //*********************************************************************

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
            //*********************************************************************
            //********************** Inicio: código agregado **********************
            //********************** 4a Modificación         **********************
            posicionMiOso += new Vector2(1, 1);
            posicionMiTexto += new Vector2(1, 0);
            //**********************   Fin: código agregado  **********************
            //*********************************************************************

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            //*********************************************************************
            //********************** Inicio: código agregado **********************
            //********************** 3a Modificación         **********************
            spriteBatch.Begin();
            spriteBatch.Draw(miOso, posicionMiOso, Color.White);
            spriteBatch.Draw(miguitarraGarageband, posicionGuitarraGarageband, Color.White);
            spriteBatch.DrawString(miFuente, miTexto, posicionMiTexto, Color.Red);
            spriteBatch.End();
            //**********************   Fin: código agregado  **********************
            //*********************************************************************

            base.Draw(gameTime);
        }
    }
}
