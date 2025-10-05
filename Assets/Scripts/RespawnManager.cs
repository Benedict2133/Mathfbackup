using UnityEngine;

public class Falldetect : MonoBehaviour
{
    public static Falldetect Instance;
    public Transform Respawn;

    private void Awake()
    {
        Instance = this;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            input player = other.GetComponent<input>();

            if (player != null)
            {

            }


            CharacterController cont = other.GetComponent<CharacterController>();

            if (cont != null)
            {
                cont.enabled = false;
            }

            other.transform.position = Respawn.position;

            if (cont != null)
            {
                cont.enabled = true;
            }
        }
    }
}
