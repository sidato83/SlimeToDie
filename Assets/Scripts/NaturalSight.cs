// George
using UnityEngine;

public class NaturalSight : ExtendedEnemySight
{
    /*
    static int count = 0;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Enemies facing will be alerted.");
            Debug.Log("Value returned" + gameObject.GetComponent<ExtendedEnemySight>().returnCollision());
            count++;
            Debug.Log(count);
            if (gameObject.GetComponent<ExtendedEnemySight>().returnCollision() == true) //learned how to get functions from other classes
            {
                Destroy(GameObject.Find("Player"));
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Exited light, Enemies have normal vision");
        }
    }
    */
}
