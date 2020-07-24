using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Bark : MonoBehaviour
{
    public GameObject barkRadius;

    [Header("CAMERA SHAKE")]
    public CinemachineVirtualCamera vCam;
    private CinemachineBasicMultiChannelPerlin virtualCameraNoise;

    public float shakeDuration = 0.3f;
    public float shakeAmplitude = 1.2f;
    public float shakeFrequency = 2.0f;

    private float shakeElapsedTime = 0f;

    

    // Start is called before the first frame update
    void Start()
    {
        if (vCam != null)
            virtualCameraNoise = vCam.GetCinemachineComponent<Cinemachine.CinemachineBasicMultiChannelPerlin>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) | Input.GetButtonDown("Fire1"))
        {
            barked();
            
        }


        if(vCam != null && virtualCameraNoise != null)
        {
            if(shakeElapsedTime > 0)
            {
                virtualCameraNoise.m_AmplitudeGain = shakeAmplitude;
                virtualCameraNoise.m_FrequencyGain = shakeFrequency;

                shakeElapsedTime -= Time.deltaTime;
            }

            else
            {
                virtualCameraNoise.m_AmplitudeGain = 1f;
                virtualCameraNoise.m_FrequencyGain = 0.01f;
                shakeElapsedTime = 0f;
            }
        }

    }

    public void barked()
    {
        shakeElapsedTime = shakeDuration;
        Instantiate(barkRadius, transform.position, transform.rotation);
    }
}
