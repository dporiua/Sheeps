using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float interactionRadius = 5f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            MoveSheepAway(clickPosition);
        }
    }

    void MoveSheepAway(Vector2 clickPosition)
    {
        foreach (GameObject sheep in GameObject.FindGameObjectsWithTag("Sheep"))
        {
            float distanceToSheep = Vector2.Distance(sheep.transform.position, clickPosition);
            if (distanceToSheep < interactionRadius)
            {
                sheep.GetComponent<SheepBehaviour>().MoveAwayFrom(clickPosition);
            }
        }
    }
}
