using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    [SerializeField] float screenWidthInUnits = 32.0f;
    [SerializeField] float minXClamp = 2.0f;
    [SerializeField] float maxXClamp = 16.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits * 2;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosInUnits, minXClamp, maxXClamp);
        transform.position = paddlePos;
	}
}
