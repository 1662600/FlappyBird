using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private TranslateMover translateMover;

    [SerializeField] private KeyCode moveUp = KeyCode.W;
    [SerializeField] private KeyCode moveDown = KeyCode.S;
    [SerializeField] private KeyCode moveLeft = KeyCode.A;
    [SerializeField] private KeyCode moveRight = KeyCode.D;

    // Use this for initialization
    void Start ()
    {
        var position = transform.position;
        Debug.Log("Ma position initiale est : " + position);
	}
	
	// Update is called once per frame
	private void Update ()
    {
        if (Input.GetKey(moveUp))
            translateMover.Move(Vector3.up);
        if (Input.GetKey(moveLeft))
            translateMover.Move(Vector3.left);
        if (Input.GetKey(moveRight))
            translateMover.Move(Vector3.right);
        if (Input.GetKey(moveDown))
            translateMover.Move(Vector3.down);
    }
    public void Awake()
    {
        translateMover = GetComponent<TranslateMover>();
    }
}
