using UnityEngine;

public class VisualCueOff : MonoBehaviour
{
    [SerializeField] public GameObject _objectDisable;
    [SerializeField] public Transform _cueParent;
    [SerializeField] public Vector3 _target;

    //[SerializeField] public Rigidbody _rigidbody;    

    //void FixedUpdate()
    //{
    //    if (_rigidbody.velocity.magnitude == 0)
    //    {
    //        _rigidbody.gameObject.SetActive(true);
    //    }
    //    else
    //    {
    //        _rigidbody.gameObject.SetActive(false);
    //    }
    //}

    void FixedUpdate()
    {
        if (_objectDisable.transform.position == _target)
        {
            _objectDisable.SetActive(false);
        }
    }
}