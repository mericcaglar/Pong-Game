using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateWall : MonoBehaviour
{
    public GameObject ColliderObjesi;
    private Vector2 screenBounds;
    void Start()
    { 
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        var yukari = Instantiate(ColliderObjesi, new Vector3(0, screenBounds.y+0.5f, 0), Quaternion.identity);
        var asagi = Instantiate(ColliderObjesi, new Vector3(0, (screenBounds.y * -1)-0.5f, 0), Quaternion.identity);
        yukari.transform.localScale = new Vector3(50, 1, 1);
        asagi.transform.localScale = new Vector3(50, 1, 1); 
    }

    
}
