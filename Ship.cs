using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceshipSurvivor
{
    internal class Ship
    {
        static public Vector2 defaultPosition = new Vector2(640, 360);
        public Vector2 position = defaultPosition;
        public int speed = 180;
        public int radius = 30;

        public void ShipUpdate(GameTime gameTime)
        {
            KeyboardState kState = Keyboard.GetState();
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (kState.IsKeyDown(Keys.Right) || kState.IsKeyDown(Keys.D) && position.X < 1280 - radius)
            {
                position.X += speed * dt;
            }

            if (kState.IsKeyDown(Keys.Left) || kState.IsKeyDown(Keys.A) && position.X > radius)
            {
                position.X -= speed * dt;
            }

            if (kState.IsKeyDown(Keys.Down) || kState.IsKeyDown(Keys.S) && position.Y < 720 - radius)
            {
                position.Y += speed * dt;
            }

            if (kState.IsKeyDown(Keys.Up) || kState.IsKeyDown(Keys.W) && position.Y > radius)
            {
                position.Y -= speed * dt;
            }
        }
    }
}
