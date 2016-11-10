using UnityEngine;
using System.Collections;

public class EnterStartSpot : MonoBehaviour {

    private GameManager gameManager;

    void OnTriggerEnter(Collider collider)
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        gameManager.SetIsAbleToStart(true);
        if (gameManager.IsAbleToStart)
        {
            Debug.Log("Start");
            gameManager.StartDash();
        }
    }
}
