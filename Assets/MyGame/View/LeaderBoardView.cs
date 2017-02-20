using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using PlayFab.ClientModels;


namespace MyGame
{
    namespace Model
    {
        public class LeaderBoardView : MonoBehaviour
        {

            void Start()
            {

            }

            void Update()
            {

            }
            public void onLeaderBoardChange(List<PlayerLeaderboardEntry> board)
            {
                Text text = GetComponentInChildren<Text>();
                text.text = "Hi-Scores\n";

                foreach (var player in board)
                {
                    text.text += player.Position + ". " + player.DisplayName + " : " + player.StatValue + "\n";
                }
            }


        }
    }
}
