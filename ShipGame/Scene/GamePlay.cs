using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using ShipGame.Device;

namespace ShipGame.Scene
{
    class GamePlay : IScene
    {
        private GameDevice gameDevice;
        private bool IsEndFlag;

        public GamePlay()
        {
            gameDevice = GameDevice.Instance();

        }
        public void Draw(Renderer renderer)
        {
            renderer.Begin();

            
            renderer.DrawTexture("backColor", Vector2.Zero);

            renderer.End();
        }


        public void Initialize()
        {

        }

        public bool IsEnd()
        {
            return IsEndFlag;
        }

        public SceneName Next()
        {
            return SceneName.GameEnding;
        }

        public void Shutdown()
        {

        }

        public void Update(GameTime gameTime)
        {
            if (Input.GetKeyTrigger(Keys.Space))
            {
                IsEndFlag = true;
            }
        }
    }
}