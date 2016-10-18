using UnityEngine;
using System.Collections;

public class ChoqueyMovimiento : MonoBehaviour {
    Vector2 moveDirection = Vector2.zero;
    public Transform enemigo;
    public GameObject enemigo2;
    public bool choque = false;
    public float velociPuti;
    // Use this for initialization
    void Start () {
        moveDirection = new Vector2(velociPuti,0);
	}
	
	// Update is called once per frame
	void Update () {
        enemigo.position = (Vector2)enemigo.position + moveDirection;

        
	}
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Muro"))
        {
            
            moveDirection *= -1;
            
        }
        
    }
}
