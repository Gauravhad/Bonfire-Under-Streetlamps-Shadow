using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChange : MonoBehaviour
{
    [SerializeField] private GameObject nightrotation;
    [SerializeField] private GameObject directionalLight;
    [SerializeField] private GameObject dayrotation;

    public Vector3 rotval;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //public void day() => directionalLight.transform.RotateAroundLocal(Vector3.left, 180.0f);

    public void Night()
    {

        //directionalLight.transform.rotation = rotation.transform.rotation;
        directionalLight.transform.localRotation = nightrotation.transform.localRotation;
    }

    public void Day ()
    {

        //directionalLight.transform.rotation = rotation.transform.rotation;
        directionalLight.transform.localRotation = dayrotation.transform.localRotation;
    }
}