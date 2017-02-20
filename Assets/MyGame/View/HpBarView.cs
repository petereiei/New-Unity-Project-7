using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.Events;
using System.Collections;

namespace MyGame
{
    namespace View
    {
        public class HpBarView : MonoBehaviour
        {

            SpriteRenderer healthBar;
            void Awake()
            {
                healthBar = GetComponent<SpriteRenderer>();
            }      

            public void HpBarChange(float health)
            {
                healthBar.material.color = Color.Lerp(Color.green, Color.red, 1 - health * 0.01f);
                healthBar.transform.localScale = new Vector2(health * 0.01f,  1);
            }

        }
        }
}
