using UnityEngine;
using System.Collections;
using MyGame.Model;


namespace MyGame
{
    namespace Model
    {
        public class InventoryController : MonoBehaviour
        {

            private GameModel gm;

            // Use this for initialization
            void Awake()
            {
                gm = GetComponent<GameModel>();
            }

            public void loadPlayFabData()
            {
                gm.load();
            }

            public void buyLife()
            {
                gm.TryBuyLives();
            }

            public void loseLife()
            {
                gm.TryLoseLife();
            }

            public void submitScore(int score)
            {
                gm.TrySubmitScore(score);
            }
            public void loadLeaderBoard()
            {
                gm.TryGetLeaderBoard();
            }
            public void checkInventory()
            {
                if (gm.gameData.live <= 0)
                    Time.timeScale = 0;
                else
                    Time.timeScale = 1;
            }
        }
    }
}
