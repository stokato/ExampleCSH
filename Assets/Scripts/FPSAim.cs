using UnityEngine;
using System.Collections;

public class FPSAim : MonoBehaviour {

    private float mouseX;
    private float mouseY;
    public bool InvertedMouse;

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update() {
        //Vector3 mousePosition = Input.mousePosition;
        //float mouseX = mousePosition.x;
        //float mouseY = mousePosition.y;

        //transform.eulerAngles = new Vector3(mouseY * 0.1f, 0, 0);

        mouseX += Input.GetAxis("Mouse X");
        if (InvertedMouse)
        {
            mouseY += Input.GetAxis("Mouse Y");
        } else
        {
            mouseY -= Input.GetAxis("Mouse Y");
        }        

        //Debug.Log(mouseX);

        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);
	}
}
