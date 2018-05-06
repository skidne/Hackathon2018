using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerObject : NetworkBehaviour
{
    float speed = 3.0f;
    public GameObject PlayerUnitPrefab;

    // Use this for initialization
    void Start()
    {

        if (isLocalPlayer == false)
        {
            // This object belongs to another player.
            return;
        }

        // Since the PlayerObject is invisible and not part of the world, give me something physical to move around!
        Debug.Log("PlayerObject::Start");
        CmdSpawnPlayer();

    }

    // Update is called once per frame
    void Update()
    {
        if (isLocalPlayer == false)
        {
            return;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            CmdMoveUnit(new Vector2(0, 3), new Vector3(0, 0, 0));
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            CmdMoveUnit(new Vector2(-3, 0), new Vector3(0, 0, 90));
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            CmdMoveUnit(new Vector2(0, -3), new Vector3(0, 0, 180));
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            CmdMoveUnit(new Vector2(3, 0), new Vector3(0, 0, 270));
        }
        else
        {
            CmdMoveUnit(new Vector2(0, 0), new Vector3());
        }
    }

    GameObject myPlayerUnit;

    [Command]
    void CmdSpawnPlayer()
    {
        // Exec on the server.
        GameObject go = Instantiate(PlayerUnitPrefab);
        myPlayerUnit = go;
        NetworkServer.Spawn(go);
    }

    [Command]
    void CmdMoveUnit(Vector2 move, Vector3 ratation)
    {
        if (myPlayerUnit == null)
        {
            return;
        }


        myPlayerUnit.GetComponent<Rigidbody2D>().velocity = move;
        myPlayerUnit.transform.eulerAngles = ratation;
    }
}