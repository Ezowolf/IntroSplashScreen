using UnityEngine;
using System.Collections;

public class ProjectPoes : MonoBehaviour {

    public int SpeedLimit = 0;

	// Use this for initialization
	void Start () 
    {
	    
	}
	
	// Update is called once per frame
	void Update () 
    {
        SpeedLimit++;
        transform.Translate(Vector3.back * Time.deltaTime * (SpeedLimit/4), Space.World);

        //Debug.Log(SpeedLimit);
        if (Input.anyKey || SpeedLimit == 100)
        {
            Application.LoadLevel("MainMenu");
        }
	}
    void FixedUpdate()
    {

    }
}
