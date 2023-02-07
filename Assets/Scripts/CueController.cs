using UnityEngine;
using UnityEngine.UIElements;
using System;

public class CueController : MonoBehaviour
{
    [SerializeField] private Transform cueParent;    

    private Rigidbody _rb;
    private Transform _target;
    private  float  _speed = 100f;
    public float RotationSpeed = 100.0f;
    public float ForceValue = 100f;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();        
    }

    private void Update()
    {       

        if (Input.GetMouseButtonDown(0))
        {
            _rb.AddForceAtPosition(transform.right * ForceValue, transform.position);
            

           // float sideForce = Input.GetAxis("Horizontal") * RotationSpeed;
           //float forwardForce = Input.GetAxis("Vertical") * _speed;
           //_rb.AddRelativeTorque(0f, 0f, forwardForce, ForceMode.Impulse);
           //_rb.AddRelativeTorque(0f, sideForce, 0f);
           //_rb.AddForce(Vector3.right * 10f, ForceMode.Impulse);
           // _rb.AddForce(10.0f, 0f, 0f, ForceMode.Impulse);                
        }
        
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            _rb.AddForce(0f, 250f, 0f);
        }
        if (cueParent != null)
        {
            Vector3 pivotVector = Input.mousePosition - Camera.main.WorldToScreenPoint(cueParent.position);
            float angle = Mathf.Atan2(pivotVector.y, pivotVector.x) * Mathf.Rad2Deg;
            cueParent.rotation = Quaternion.AngleAxis(-angle - 180, Vector3.up);
        }        
       
    }    

    void FixedUpdate()
    { 
        if (Input.GetKey(KeyCode.W))
        {
            _rb.AddForce(0f, 0f, 5);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _rb.AddForce(-5, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            _rb.AddForce(0f,0f, -5);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rb.AddForce(5, 0f, 0f);
        }
    }
}
