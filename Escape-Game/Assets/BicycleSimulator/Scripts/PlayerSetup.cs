using UnityEngine;
using UnityEngine.Networking;

[NetworkSettings(channel = 1, sendInterval = 0.003f)]
public class PlayerSetup : NetworkBehaviour
{
    [SerializeField]
    Behaviour[] componentsToDisable;

    Camera sceneCamera;

    GameObject[] player;

    void Start()
    {
        Physics.gravity = new Vector3(0, -500F, 0);
        if (!isLocalPlayer)
        {
            for(int i = 0;i < componentsToDisable.Length; i++)
            {
                componentsToDisable[i].enabled = false;
            }
        }
        else
        {
            sceneCamera = Camera.main;
            if(sceneCamera != null)
            {
                sceneCamera.gameObject.SetActive(false);
            }
        }

        if(!isServer)
        {
            if (player == null)
                player = GameObject.FindGameObjectsWithTag("Player");

            if (player.Length != 0)
            {
                Debug.Log(player.Length);
            }

            foreach (GameObject i in player)
            {
                NetworkServer.Destroy(i);
            }
        }
    }

    void OnDisable()
    {
        if(sceneCamera != null)
        {
            sceneCamera.gameObject.SetActive(true);
        }

    }
}
