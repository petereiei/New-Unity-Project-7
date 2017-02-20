using UnityEngine;
using System.Collections;
using UnityEngine.Events;


namespace MyGame
{

    [System.Serializable]
    public class HitTriggerEvent : UnityEvent<Collider2D> { }

    public class EventManager : MonoBehaviour
    {

        private EventManager() { }
        [SerializeField]
        public static HitTriggerEvent onHitTriggerEvents = new HitTriggerEvent();

    }
}
