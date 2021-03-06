using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class VentExit : MonoBehaviour
{
    public Collider2D insideCollider;
    public Transform outside;

    private GameObject player;

    private bool canEnter = false;

    // Player UI
    public TMP_Text entertext;

    // Start is called before the first frame update
    void Start()
    {
        entertext = GameManager.instance.VentText;
    }

    // Update is called once per frame
    void Update()
    {
        if (canEnter == true)
        {
            //Debug.Log("Exit vent?");
            if (Input.GetKeyDown(KeyCode.E))
            {
                FindObjectOfType<AudioManager>().Play("Vent");
                //Debug.Log("Key press detected, activating now!");
                player = GameObject.FindGameObjectWithTag("Player");
                player.GetComponent<Transform>().position = outside.transform.position;
            }
        }
        else
        {
            
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            canEnter = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            canEnter = false;
            entertext.text = "";
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            entertext.text = "Press E to exit vent.";
        }
    }
}
