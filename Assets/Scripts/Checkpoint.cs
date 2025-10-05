using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] List<GameObject> checkpoints;
    [SerializeField] Vector3 vectorpoints;
    [SerializeField] float dead;

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < -dead)
        {
            player.transform.position = vectorpoints;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        vectorpoints = player.transform.position;
        Destroy(other.gameObject);
    }
}
