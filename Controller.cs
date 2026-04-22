using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SpaceshipSurvivor
{
    internal class Controller
    {
        public List<Asteroid> asteroids = new List<Asteroid>();
        public double timer = 2;

        public void ConUpdate(GameTime gameTime)
        {
            timer -= gameTime.ElapsedGameTime.TotalSeconds;

            if(timer <= 0)
            {
                asteroids.Add(new Asteroid(250));
                timer = 2;
            }
        }
    }
}
