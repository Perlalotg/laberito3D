﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

  public float speedH = 1.0f;
  public float speedV = 1.0f;

  private float yaw = 0.0f;
  private float pitch = 0.0f;


  // Update is called once per frame
  void Update()
  {

    yaw += speedH * Input.GetAxis("Mouse X");
    pitch -= speedV * Input.GetAxis("Mouse Y");

    transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);



  }
}