using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour;
public Transform target;
public float follow;

public float minX, maxX;
public float minY, maxY;

{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void FixedUpdate(){

        if(target!=null){

            Vector2 newCamPosition=Vector2.Lerp(Transform.position, target.position, Time.deltatime * follow);
            float ClampX = Mathf.clamp(newCamPosition.x, minX, maxX);
            float ClampX = Mathf.clamp(newCamPosition.x, minY, maxY);
        }
    }
}
