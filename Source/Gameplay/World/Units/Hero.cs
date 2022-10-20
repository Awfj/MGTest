using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Hero : Unit
    {
        public Hero(string PATH, Vector2 POS, Vector2 DIMS) : base(PATH, POS, DIMS)
        {
            speed = 2.0f;
        }

        public override void Update(Vector2 OFFSET)
        {
            if (Globals._keyboard.GetPress("A"))
            {
                pos = new Vector2(pos.X - speed, pos.Y);
            }

            if (Globals._keyboard.GetPress("D"))
            {
                pos = new Vector2(pos.X + speed, pos.Y);
            }

            if (Globals._keyboard.GetPress("W"))
            {
                pos = new Vector2(pos.X, pos.Y - speed);
            }

            if (Globals._keyboard.GetPress("S"))
            {
                pos = new Vector2(pos.X, pos.Y + speed);
            }

            rot = Globals.RotateTowards(
                pos, 
                new Vector2(Globals._mouse.newMousePos.X, Globals._mouse.newMousePos.Y));

            if (Globals._mouse.LeftClick())
            {
                GameGlobals.PassProjectile(new Fireball(
                    new Vector2(pos.X, pos.Y), 
                    this,
                    new Vector2(Globals._mouse.newMousePos.X, Globals._mouse.newMousePos.Y)));
            }

            base.Update();
        }

        public override void Draw(Vector2 OFFSET)
        {
            base.Draw(OFFSET);
        }
    }
}
