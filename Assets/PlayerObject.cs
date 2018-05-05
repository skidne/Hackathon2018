using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerObject : NetworkBehaviour {
    float speed = 3.0f;
    public GameObject PlayerUnitPrefab;

	// Use this for initialization
	void Start () {

        if( isLocalPlayer == false ) {
            // This object belongs to another player.
            return;
        }

        // Since the PlayerObject is invisible and not part of the world, give me something physical to move around!
        Debug.Log("PlayerObject::Start");
        CmdSpawnPlayer();
		
	}

	// Update is called once per frame
	void Update () {
        if( isLocalPlayer == false) {
            return;
        }

        var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        CmdMoveUnit(move);
	}

    GameObject myPlayerUnit;

    [Command]
    void CmdSpawnPlayer() {
        // Exec on the server.
        GameObject go = Instantiate(PlayerUnitPrefab);
        myPlayerUnit = go;
        NetworkServer.Spawn(go);
    }

    [Command]
    void CmdMoveUnit(Vector3 move) {
        if(myPlayerUnit == null) {
            return;
        }


        myPlayerUnit.transform.position += move * speed * Time.deltaTime;
    }
}
