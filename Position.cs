using UnityEngine;
using System.Collections;

public class Position : MonoBehaviour
{

    private bool isActive = false;

    CardboardHead head = null;

    // Use this for initialization
    void Start()
    {

        head = Camera.main.GetComponent<StereoController>().Head;

    }

    // Update is called once per frame
    void Update()
    {

        if (!isActive && Cardboard.SDK.Triggered)
        {
            isActive = true;
        }

        else if (isActive && Cardboard.SDK.Triggered)
        {
            isActive = false;
        }

        if (isActive)
        {
            transform.localPosition += new Vector3(0, 0, -1).normalized * 1 * Time.deltaTime;
        }

    }
}
