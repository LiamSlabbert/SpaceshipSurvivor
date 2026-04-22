using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceshipSurvivor
{
    internal class Ship
    {
        public Vector2 position = new Vector2(100, 100);
        public int speed = 180; 

        public void ShipUpdate(GameTime gameTime)
        {
            KeyboardState kState = Keyboard.GetState();
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (kState.IsKeyDown(Keys.Right) || kState.IsKeyDown(Keys.D))
            {
                position.X += speed * dt;
            }

            if (kState.IsKeyDown(Keys.Left) || kState.IsKeyDown(Keys.A))
            {
                position.X -= speed * dt;
            }

            if (kState.IsKeyDown(Keys.Down) || kState.IsKeyDown(Keys.S))
            {
                position.Y += speed * dt;
            }

            if (kState.IsKeyDown(Keys.Up) || kState.IsKeyDown(Keys.W))
            {
                position.Y -= speed * dt;
            }
        }
    }
}
