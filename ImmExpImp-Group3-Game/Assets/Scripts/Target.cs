using UnityEngine;

public class Target : MonoBehaviour, IArrowHittable
{
    public float forceAmount = 1.0f;
    public Material otherMaterial = null;

    private new Rigidbody rigidbody;

    public void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();

    }

    public void Hit(Arrow arrow)
    {
        ApplyForce(arrow);
        DisableCollider(arrow);
        ApplyMaterial();
        rigidbody.constraints = RigidbodyConstraints.None;
    }

    private void ApplyMaterial()
    {
        if (TryGetComponent(out MeshRenderer meshRenderer))
            meshRenderer.material = otherMaterial;
    }

    private void ApplyForce(Arrow arrow)
    {
        if (TryGetComponent(out Rigidbody rigidbody))
            rigidbody.AddForce(arrow.transform.forward * forceAmount);
    }

    private void DisableCollider(Arrow arrow)
    {
        if (arrow.TryGetComponent(out Collider collider))
            collider.enabled = false;
    }
}
