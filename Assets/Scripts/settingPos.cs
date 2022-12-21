using UnityEngine;
public class settingPos : MonoBehaviour
{
    public Transform tf;
    public GameObject p0, p1, p2;    
    public float UpForce; 
    Vector3[] dir = new Vector3[2];

    void Update()
    {
        dir[0] = p0.transform.position;
        Vector3 temp = transform.rotation * Vector3.forward;
        temp *= UpForce;
        dir[0] += temp;
        p1.transform.position = dir[0];
        p2.transform.position = dir[1];
    }
}