using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using ShipGame.Actor;
using ShipGame.Device;

namespace ShipGame.Scene
{
    class GamePlay : IScene
    {
        private GameDevice gameDevice;
        private GameObjectManager gameObjectManager;
        private Renderer renderer;
        private Player player;
        private Bermuda bermuda;
        private bool IsEndFlag;

        private Vector2 startPlayerPosi = new Vector2(32 * 2, 32 * 12);
        private Vector2 bermPosi = new Vector2(0,0);

        private Vector2 startPlayerOrigin = new Vector2(0, 0);
        private Vector2 bremOri = new Vector2(0, 0);

        private float startPlayerRota = 0;
        //private float startRota = 0;

        private Vector2 startBermudaPosi = new Vector2(600, 600);

        public GamePlay()
        {
            gameDevice = GameDevice.Instance();
            gameObjectManager = new GameObjectManager();
        }
        public void Draw(Renderer renderer)
        {
            renderer.Begin();

            
            renderer.DrawTexture("backColor", Vector2.Zero);
            gameObjectManager.Draw(renderer);
            renderer.End();
        }


        public void Initialize()
        {
            IsEndFlag = false;
            gameObjectManager.Initialize();

            //プレイヤーの生成
            player = new Player(startPlayerPosi, startPlayerRota,startPlayerOrigin, gameDevice, gameObjectManager);

            //バミューダの生成
            bermuda = new Bermuda(bermPosi,bremOri,gameDevice,gameObjectManager);

            //プレイヤーにIDを設定
            gameObjectManager.Add(player);

            gameObjectManager.Add(bermuda);


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
            gameObjectManager.Update(gameTime);
            if (Input.GetKeyTrigger(Keys.Space))
            {
                IsEndFlag = true;
            }
        }
    }
}