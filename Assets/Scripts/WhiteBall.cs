using UnityEngine;

public class WhiteBall : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private CueController cueController;
    [SerializeField] private float minVelosityToStop;

    private void Awake()
    {
        if (!rb)
            rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (rb.velocity.magnitude <= minVelosityToStop)
        {
            rb.velocity = Vector3.zero;
            cueController.SetCueActive(true);
        }
    }
}
