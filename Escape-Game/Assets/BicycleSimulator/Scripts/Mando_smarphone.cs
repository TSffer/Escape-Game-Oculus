using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Mando_smarphone : MonoBehaviour
{
    // Start is called before the first frame up
    public GameObject[] player;
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("PrefabPlayer1");
        Debug.Log(player.Length);
        if (player.Length == 0)
        {
            Debug.Log("No Player objects are tagged with");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(player.Length);
    }
}
