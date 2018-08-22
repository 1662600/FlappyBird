using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    private BirdPhysics birdPhysics;
    [SerializeField] private KeyCode flapKey = KeyCode.Space;

  
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        //if (Input.GetKey(moveUp))
        //    translateMover.Move(Vector3.up);
        //if (Input.GetKey(moveLeft))
        //    translateMover.Move(Vector3.left);
        //if (Input.GetKey(moveDown))
        //    translateMover.Move(Vector3.down);

        if (Input.GetKeyDown(flapKey))
        {
            birdPhysics.Flap();
        }
        
    }
    public void Awake()
    {
        birdPhysics = transform.root.GetComponentInChildren<BirdPhysics>();
    }
}

