using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour {

    public Transform player;

    void LateUpdate()
    {
        Vector3 _Position = player.position;
        _Position.y = transform.position.y;
        transform.position = _Position;
    }
}
