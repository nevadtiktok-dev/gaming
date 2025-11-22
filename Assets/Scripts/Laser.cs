using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Toon.HDRP.Samples;

public class Laser : MonoBehaviour
{
    public GameObject laserBeam;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        laserBeam.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){   
        laserBeam.SetActive(true);
        StartCoroutine(TurnOffLaser());
    }
    }

    void OnMouseDown()
    {
        laserBeam.SetActive(true);
        StartCoroutine(TurnOffLaser());
    }

    IEnumerator TurnOffLaser()
    {
        yield return new WaitForSeconds(0.2f);
        laserBeam.SetActive(false);
    }
}
