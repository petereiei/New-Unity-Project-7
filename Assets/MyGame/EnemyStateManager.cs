using UnityEngine;
using System.Collections;
using UnityEngine.Events;



namespace MyGame
{
    public class AnimatorControllerEvent : UnityEvent<Animator> { }

    public class EnemyStateManager : MonoBehaviour
    {

        public static AnimatorControllerEvent IdleEventEnter = new AnimatorControllerEvent();
        public static AnimatorControllerEvent IdleEventExit = new AnimatorControllerEvent();
        public static AnimatorControllerEvent DamagedEventEnter = new AnimatorControllerEvent();
        public static AnimatorControllerEvent DamagedEventExit = new AnimatorControllerEvent();
        public static AnimatorControllerEvent DeathEventEnter = new AnimatorControllerEvent();
        public static AnimatorControllerEvent DeathEventExit = new AnimatorControllerEvent();

        private EnemyStateManager() { }
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
