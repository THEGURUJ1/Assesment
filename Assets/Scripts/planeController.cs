using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed= 90.0f;
    void Start()
    {
      if(Input.GetKey("space"))
        {
            speed=90.0f;
        }  
    }

    // Update is called once per frame
    void Update()
    {
        




        transform.position +=transform.forward*Time.deltaTime * speed*2;

        speed-=transform.forward.y*Time.deltaTime*25.0f;
        if(speed<35.0f)
        {
            speed=35.0f;
        }

        transform.Rotate(Input.GetAxis ("Vertical"), 0.0f, -Input.GetAxis ("Horizontal"));

        float terrainHeightWhereWeAre = Terrain.activeTerrain.SampleHeight( transform.position);

        if(terrainHeightWhereWeAre >transform.position.y) {

            transform.position = new Vector3(   transform.position.x,
                                                terrainHeightWhereWeAre, 
                                                transform.position.z);
    }
}}
