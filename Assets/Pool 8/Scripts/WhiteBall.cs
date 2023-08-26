using UnityEngine;

public class WhiteBall : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private CueController cueController;
    [SerializeField] private float minVelosityToStop;

    private bool _isBallReachedMinSpeed;

    private void Awake()
    {
        if (!rb)
            rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (cueController.IsCueActive)
            return;

        if (_isBallReachedMinSpeed)
        {
            if (rb.velocity.magnitude < minVelosityToStop)
            {
                _isBallReachedMinSpeed = false;
                SetIsKinematic(true);
                rb.velocity = Vector3.zero;
                cueController.SetCueActive(true);
            }
        }
        else
        {
            if (rb.velocity.magnitude > minVelosityToStop)
            {
                _isBallReachedMinSpeed = true;
            }
        }
    }

    public void SetIsKinematic(bool isKinematic)
    {
        rb.isKinematic = isKinematic;
    }
}
