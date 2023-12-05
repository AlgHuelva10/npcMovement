using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class npcMovement : MonoBehaviour
{
    // Variable de vida para el NPC (pública)
    public int npcHealth = 5;

    // Variable de velocidad para el NPC (pública)
    public float npcSpeed = 1.2f;

    // Variable de nivel para el NPC (pública)
    public int npcLevel = 1;

    //Variable de movimiento para el NPC
    Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        position.z += npcSpeed * Time.deltaTime;
        transform.position = position;
    }
}
