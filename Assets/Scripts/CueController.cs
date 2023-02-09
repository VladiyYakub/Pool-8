using UnityEngine;
using UnityEngine.UIElements;
using System;
using static UnityEngine.GraphicsBuffer;

public class CueController : MonoBehaviour
{
    [SerializeField] private Transform cueParent;
    [SerializeField] private GameObject cue;



    [SerializeField] public Vector3 _target;
    [SerializeField] public GameObject _objectDisable;


    private Rigidbody _rb;
    public float RotationSpeed = 100.0f;
    public float ForceValue = 100f;

    private bool _isCueActive;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();     
        _isCueActive = true;
    }

    private void FixedUpdate()
    {
        if (_isCueActive)
        {
            if (Input.GetMouseButtonUp(0))
            {
                _rb.AddForce(cueParent.right * ForceValue, ForceMode.Force);
                _isCueActive = false;
            }
            else if (cueParent != null)
            {
                Vector3 pivotVector = Input.mousePosition - Camera.main.WorldToScreenPoint(cueParent.position);
                float angle = Mathf.Atan2(pivotVector.y, pivotVector.x) * Mathf.Rad2Deg;
                cueParent.rotation = Quaternion.AngleAxis(-angle - 180, Vector3.up);
            }


            if (_objectDisable.transform.position == _target)
            {
                _objectDisable.SetActive(false);
            }

        }

        cue.SetActive(_isCueActive);
    }    

    public void SetCueActive(bool isActive)
    {
        _isCueActive = isActive;
    }
}
