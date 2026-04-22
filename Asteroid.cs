using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace SpaceshipSurvivor
{
    internal class Asteroid
    {
        public Vector2 position;
        public int speed;
        public int radius = 59;

        public Asteroid(int newSpeed) 
        {   
            Random rand = new Random();
            int randSpawnY = rand.Next(radius, 721 - radius);
            speed = newSpeed;
            position = new Vector2(1380, randSpawnY);
        }

        public void AsteroidUpdate(GameTime gameTime)
        {
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

            position.X -= speed * dt;
        }
    }
}
