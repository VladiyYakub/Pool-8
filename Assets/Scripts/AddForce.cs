using UnityEngine;

public class AddForce : MonoBehaviour
{
    [SerializeField] private Transform cueParent;

    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (cueParent != null)
        {
            Vector3 pivotVector = Input.mousePosition - Camera.main.WorldToScreenPoint(cueParent.position);
            float angle = Mathf.Atan2(pivotVector.y, pivotVector.x) * Mathf.Rad2Deg;
            cueParent.rotation = Quaternion.AngleAxis(-angle - 180, Vector3.up);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(0f, 250, 0f);
        }
    }
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.A))
        {
            _rb.AddForce(-5, 0f, 0f);
        }
        if(Input.GetKey(KeyCode.D)) 
        {
            _rb.AddForce(5, 0f, 0f);
        }
        if(Input.GetKey(KeyCode.W))
        {
            _rb.AddForce(0f, 0f, 5);
        }
        if(Input.GetKey(KeyCode.S))
        {
            _rb.AddForce(0f,0f, -5);
        }
    }
}
