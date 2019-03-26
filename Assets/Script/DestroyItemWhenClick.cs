using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyItemWhenClick : MonoBehaviour {

    //Button Delete in Item
    public void DeleteContentObject()
    {
        Destroy(gameObject);
    }
}
