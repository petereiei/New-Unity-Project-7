using UnityEngine;
using UnityEngine.Events;
using System.Collections;

namespace MyGame {
    namespace Model {

        [System.Serializable]
        public class HealthChangedEvent : UnityEvent<float> { }

        [System.Serializable]
        public class PlaneModel : MonoBehaviour
        {

            [SerializeField]
            private float hp = 100f;
         	
			public GameObject FX;
            public float maxSpeed = 5f;
            public float damageAmount = 10f;


            public float Health
            {
                get { return hp; }
                set
                {
                    hp = value;
                    if (hp > 100f) hp = 100f;
                    onHealthChangedEvents.Invoke(hp);
                }
            }
            [SerializeField]
            public HealthChangedEvent onHealthChangedEvents;

          
        }
    }	
}
