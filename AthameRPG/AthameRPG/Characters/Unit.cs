﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using AthameRPG.GameEngine;

namespace AthameRPG.Characters
{
    public class Unit
    {
        private Rectangle cropCurrentFramePlayer;
        private Vector2 coordinatesPlayer;

        public Unit()
        {
            this.CropCurrentFramePlayer = cropCurrentFramePlayer;
            
        }

        public Rectangle CropCurrentFramePlayer
        {
            get
            {
                return this.cropCurrentFramePlayer;
            }
            private set
            {
                this.cropCurrentFramePlayer = new Rectangle(0, 0, 32, 48);
            }
        }

        public virtual void LoadContent()
        {

        }
        public virtual void UnloadContent()
        {

        }

        public virtual void Update(GameTime gameTime)
        {
            // JUST FOR TEST !
            coordinatesPlayer.X += 0.1f; 
            coordinatesPlayer.Y += 0.1f;
        }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(CharacterManager.Instance.PlayerImage, coordinatesPlayer, CropCurrentFramePlayer, Color.White);
        }
    }
}
