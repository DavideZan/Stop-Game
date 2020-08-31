using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderSwitcher : MonoBehaviour
{
    public Vector2[] sizes;
    public Vector2[] offsets;

    private BoxCollider2D collider;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
    }

    void SetSize(int which)
    {
        collider.size = sizes[which];
        collider.offset = offsets[which];
    }

    public void SwitchCollider(int animationFrame)
    {
        switch (animationFrame)
        {
            case 0: case 12: 
            //first collider
                SetSize(0);
                break;        
            case 1: case 11:
            //second collider
                SetSize(1);
                break;         
            case 2: case 10:
                SetSize(2);
                break;   
            case 3: case 9:
                SetSize(3);
                break;       
            case 4: case 8:
                SetSize(4);
                break;    
            case 5: case 7:
                SetSize(5);
                break;    
            case 6: 
                SetSize(6);
                break;   

            default: 
                Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAERRORE NEL COLLIDER");
                break;
        }
    }
}
