using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class KnopfSteuerung : MonoBehaviour
{

    [SerializeField]
    public Transform Player;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    private float playerSpeed = 1.0f;
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public bool isGrounded;
    bool isButtonOnePressed = false;
    bool isButtonTwoPressed = false;
    bool isButtonThreePressed = false;
    bool isButtonFourPressed = false;
    bool isButtonFivePressed = false;


    void Start()
    {
        isButtonOnePressed = false;

        button1 = GameObject.Find("VorneKnopf");
        button2 = GameObject.Find("HintenKnopf");
        button3 = GameObject.Find("LinksKnopf");
        button4 = GameObject.Find("RechtsKnopf");
        button5 = GameObject.Find("SprungKnopf");

        button1.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        button1.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

        button2.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        button2.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

        button3.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        button3.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

        button4.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        button4.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

        button5.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        button5.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

    }

    void Update()
    {
        Debug.Log(isButtonOnePressed);
        if (isButtonOnePressed == true)
        {
            Player.transform.position += playerSpeed * Player.transform.forward;

            Debug.Log("1");
        }
        else if (isButtonTwoPressed == true)
        {
            Player.transform.position += playerSpeed * -Player.transform.forward;

            Debug.Log("2");
        }

        else if (isButtonThreePressed == true)
        {
            Player.transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * playerSpeed, Space.World);
            Debug.Log("3");
        }

        else if (isButtonFourPressed == true)
        {
            Player.transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * playerSpeed, Space.World);
            Debug.Log("4");
        }
        else if (isButtonFivePressed == true)
        {
            //rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            //isGrounded = false;
            Debug.Log("5");
        }


    }
 
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("test");
        switch (vb.VirtualButtonName)
        {

            //up
            case "button1":
                isButtonOnePressed = true;
                break;
            //down
            case "button2":
                isButtonTwoPressed = true;
                break;
            //left
            case "button3":
                isButtonThreePressed = true;
                break;
            //right
            case "button4":
                isButtonFourPressed = true;
                break;
            case "button5":
                isButtonFourPressed = true;
                break;
        }

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        switch (vb.VirtualButtonName)
        {
            //up
            case "button1":
                isButtonOnePressed = false;
                break;
            //down
            case "button2":
                isButtonTwoPressed = false;
                break;
            //left
            case "button3":
                isButtonThreePressed = false;
                break;
            //right
            case "button4":
                isButtonFourPressed = false;
                break;
            case "button5":
                isButtonFourPressed = false;
                break;
        }

    }

}