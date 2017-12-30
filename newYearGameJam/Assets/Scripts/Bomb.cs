using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {

    // mennyi idő múlva robban
    public float detonationTime = 1f;

    // bomba counter, növeljük frissítésnél, 
    // ha eléri a detonationTimet, akkor felrobban
    public float currentBombType = 0f;
    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        // növeljük a timert a robbanásig
        currentBombType += 0.01f;

        if (currentBombType >= detonationTime)
        {
            // TODO create new explosion
            // TODO pooling
            Destroy(GetComponent<SpriteRenderer>());
        }
    }
}
