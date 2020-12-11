using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionRenderer : MonoBehaviour
{
    // Start is called before the first frame update   
    private int sortingOrderBase=5000;
    private Renderer myRenderer;
    public bool staticPostion;
    private void Awake()
    {
        
        myRenderer = gameObject.GetComponent<Renderer>();
    }

    private void LateUpdate()
    {
        myRenderer.sortingOrder =(int)(sortingOrderBase - transform.position.y);
        if (staticPostion == true)
        {
            Destroy(this);
        }
    }

}
