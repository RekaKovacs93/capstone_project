using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidableObject : MonoBehaviour

{

    public EventManager eventManager;

    private Collider2D z_Collider;
    [SerializeField]
    private ContactFilter2D z_Filter;
    private List<Collider2D> z_CollidedObjects = new List<Collider2D>(1);

    private void Start()
    {
        Debug.Log("Starting collider script");
        //fetch the game object and set it as a collider
        z_Collider = GetComponent<Collider2D>();
    }

    private void Update()
    {
        //give the object a list of things that can collide with it and the results of that collision.
        z_Collider.OverlapCollider(z_Filter, z_CollidedObjects);
        foreach(var o in z_CollidedObjects)
        {
            Debug.Log("Collided with " + o.name);
            //eventManager.ResetScene();
        }
    }
}
