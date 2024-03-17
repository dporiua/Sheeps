using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalLogic : MonoBehaviour
{
    List<GameObject> sheepList = new List<GameObject>();

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Sheep"))
        {
            sheepList.Add(collision.gameObject);
            Debug.Log("Sheep added to list");
        }
    }

    void Update()
    {
        if (sheepList.Count == 5)
        {
            SceneManager.LoadScene("VictoryScene");
        }
    }
}
