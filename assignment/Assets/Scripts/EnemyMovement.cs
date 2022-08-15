using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    public GameObject EndGame;
    float currentDistance=0.0f;
    public float speed = 1000;
    void Start()
    {
        // EndGame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        currentDistance += Time.deltaTime;
       if (currentDistance >= speed)
         {
             currentDistance = speed;
         }
         float Perc = currentDistance / speed;
         gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, Player.transform.position, Perc);
    }

    void OnCollisionEnter(Collision other) {
        if(other.collider.name == "MainPlayer"){
            EndGame.SetActive(true);
            Time.timeScale=0;
        }
    }
}
