using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Toon.HDRP.Samples;
using TMPro;
using UnityEngine.UIElements;

public class Laser : MonoBehaviour
{
    public GameObject laserBeam;
    public TMP_Text ammoamount;
    public GameObject penis;

    private float ammolaser = 10;

    void Start()
    {
        laserBeam.SetActive(false);
        ammolaser = 10;
        ammoamount.SetText(ammolaser +" / 10");
        
    }


    void Update()
    {
        if(Input.GetKey(KeyCode.R)){
            reloadlaser();
            ammolaser=10;
        }

        if (Input.GetMouseButtonDown(0) && ammolaser>0){   
        laserBeam.SetActive(true);
        StartCoroutine(TurnOffLaser());
        ammolaser -= 1;
        ammoamount.SetText(ammolaser +" / 10");
        }
        else if (Input.GetMouseButtonDown(0) && ammolaser < 1){
            reloadlaser();
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

    void reloadlaser()
    {
        ammoamount.SetText(ammolaser +" / 10");
        ammolaser = 11;
    }
}
