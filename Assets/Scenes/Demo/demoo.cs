using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class demoo : NetworkBehaviour
{
    void HandleMovemnt()
    {
        if (isLocalPlayer)
        {
            float moveHori = Input.GetAxis("Horizontal");
            float moveVerti = Input.GetAxis("Vertical");
            Vector3 movment = new Vector3(moveHori * 0.1f, moveVerti*0.1f, 0);
            transform.position = transform.position + movment;
        }
    }

    private void Update()
    {
        HandleMovemnt();
    }
}
