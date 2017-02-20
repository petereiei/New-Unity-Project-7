using UnityEngine;
using System.Collections;

public class CCK : MonoBehaviour {

    public void ChangeScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
