using UnityEngine;

public class MaterialApplier : MonoBehaviour
{
    public Material otherMaterial; // Material ที่จะถูกใช้เมื่อเรียก ApplyOther()
    private Material originalMaterial; // Material เริ่มต้น

    private Renderer objectRenderer; // Renderer ของ GameObject

    void Start()
    {
        objectRenderer = GetComponent<Renderer>(); // รับค่า Renderer ของ GameObject
        originalMaterial = objectRenderer.material; // เก็บ Material เริ่มต้น
    }

    // เมทอดสำหรับใช้ Material แบบ otherMaterial
    public void ApplyOther()
    {
        if (objectRenderer != null && otherMaterial != null)
        {
            objectRenderer.material = otherMaterial; // เปลี่ยน Material เป็น otherMaterial
        }
    }

    // เมทอดสำหรับใช้ Material เริ่มต้น
    public void ApplyOriginal()
    {
        if (objectRenderer != null && originalMaterial != null)
        {
            objectRenderer.material = originalMaterial; // เปลี่ยน Material เป็น Material เริ่มต้น
        }
    }

    
}
