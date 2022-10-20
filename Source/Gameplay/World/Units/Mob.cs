using Microsoft.Xna.Framework;
using SharpDX.MediaFoundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Mob : Unit
    {
        public Mob(string PATH, Vector2 POS, Vector2 DIMS) : base(PATH, POS, DIMS)
        {
            speed = 2.0f;
        }

        public virtual void Update(Vector2 OFFSET, Hero HERO)
        {
            AI(HERO);            

            base.Update(OFFSET);
        }

        public virtual void AI()
        {

        } 

        public override void Draw(Vector2 OFFSET)
        {
            base.Draw(OFFSET);
        }
    }
}
