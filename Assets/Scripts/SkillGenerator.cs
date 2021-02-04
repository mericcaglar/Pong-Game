using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillGenerator : MonoBehaviour
{
    public GameObject[] skillBall;
    
    private Vector2 screenBounds;

    ArrayList skillList = new ArrayList();
    public bool isSkillBallOnScreen;

    void Start()
    {
        screenBounds =
            Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        isSkillBallOnScreen = false;
        Debug.Log("+X ekseni: "+ screenBounds.x);
        Debug.Log("-X ekseni: "+ screenBounds.x*-1);
        Debug.Log("----------------------------------------");
        Debug.Log("+Y ekseni: "+ screenBounds.y);
        Debug.Log("-Y ekseni: "+ screenBounds.y*-1);
        
    }

    
    void Update()
    {
        if (isSkillBallOnScreen == false)
        {
            StartCoroutine(spawnSkill());
            skillList.Add(1);
        }
        
        if (skillList.Count > 0)
        {
            StopCoroutine(spawnSkill());
            isSkillBallOnScreen = true;
            skillList.Clear();
        }
    }

    IEnumerator spawnSkill(){
        yield return new WaitForSeconds(5);
        Instantiate(skillBall[Random.Range(0,skillBall.Length)], new Vector3(Random.Range(-screenBounds.x+2f,screenBounds.x-2f),Random.Range(-screenBounds.y+2f,screenBounds.y-2f)), Quaternion.identity);
    }
    
    
}
    