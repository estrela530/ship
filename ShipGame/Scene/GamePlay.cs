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
        private Ship ship;
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

<<<<<<< HEAD
            //バミューダの生成
            bermuda = new Bermuda(bermPosi,bremOri,gameDevice,gameObjectManager);
=======
            ship = new Ship(new Vector2(), 0.0f, new Vector2(), gameDevice, gameObjectManager);
>>>>>>> addf757ce4b786dd6a2c50c6dfcc2cd5081e923e

            //プレイヤーにIDを設定
            gameObjectManager.Add(player);
            gameObjectManager.Add(ship);

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