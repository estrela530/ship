using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using ShipGame.Util;
using ShipGame.Device;

namespace ShipGame.Actor
{
    class Whirlpool : GameObject
    {
        private IGameObjectMediator mediator;

        public Whirlpool(Vector2 position, Vector2 origin, GameDevice gameDevice,
           IGameObjectMediator mediator)
           : base("blue", position, 0, origin, 32, 1280, gameDevice)
        {
            this.mediator = mediator;
        }

        /// <summary>
        /// コピーコンストラクタ
        /// </summary>
        /// <param name="other"></param>
        public Whirlpool(Whirlpool other)
            : this(other.position, other.origin, other.gameDevice, other.mediator)
        {

        }

        public override object Clone()
        {
            return new Whirlpool(this);
        }

        public override void Hit(GameObject gameObject)
        {
            
        }

        public override void Update(GameTime gameTime)
        {
            
        }
    }
}
