using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
  [SerializeField]
  Camera FrontCamera;
  [SerializeField]
  Camera BackCamera;
  private bool switchCam = false;
  private bool backCam = false;
  void Start()
  {
    FrontCamera.GetComponent<Camera>().enabled = true;
    BackCamera.GetComponent<Camera>().enabled = false;

  }
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.M))
    {
      switchCam = !switchCam;
      backCam = false;
    }
    if (Input.GetKeyDown(KeyCode.N))
    {
      switchCam = false;
      backCam = true;
    }
    if (switchCam)
    {
      FrontCamera.GetComponent<Camera>().enabled = true;
      BackCamera.GetComponent<Camera>().enabled = false;
    }
    else if (backCam)
    {
      FrontCamera.GetComponent<Camera>().enabled = false;
      BackCamera.GetComponent<Camera>().enabled = true;
    }
  }
}
