using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Fireball : Projectile2d
    {
        public bool done;
        public float speed;
        public Vector2 direction;
        public Unit owner;
        public McTimer timer;

        public Fireball(Vector2 POS, Unit OWNER, Vector2 TARGET) 
            : base("2d\\Projectiles\\Fireball", POS, new Vector2(20, 20), OWNER, TARGET)
        {
        }
        public override void Update(Vector2 OFFSET, List<Unit> UNITS)
        {
            base.Update(OFFSET, UNITS);
        }
        public override void Draw(Vector2 OFFSET)
        {
            base.Draw(OFFSET);
        }
    }
}
