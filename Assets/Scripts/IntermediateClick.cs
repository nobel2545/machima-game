using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntermediateClick : MonoBehaviour
{
    private MaterialApplier lastMaterialApplier; // เก็บ MaterialApplier ของ GameObject ที่ถูกคลิกครั้งล่าสุด

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (LookForGameObject(out hit))
            {
                GameObject targetObject = hit.collider.gameObject;

                // ถ้ามี MaterialApplier ที่เกี่ยวข้องกับ GameObject
                if (targetObject.TryGetComponent(out MaterialApplier materialApplier))
                {
                    // ถ้าไม่มี MaterialApplier ที่ถูกคลิกก่อนหน้านี้ หรือถ้า MaterialApplier ที่ถูกคลิกเป็น Material หลัก
                    if (lastMaterialApplier == null || materialApplier != lastMaterialApplier)
                    {
                        // เปลี่ยน Material ใหม่
                        materialApplier.ApplyOther();
                        lastMaterialApplier = materialApplier; // เก็บ MaterialApplier ที่ถูกคลิกไว้
                    }
                    else // ถ้า MaterialApplier ที่ถูกคลิกเป็น Material อื่น ๆ
                    {
                        // กลับไปเป็น Material เดิม
                        materialApplier.ApplyOriginal();
                        lastMaterialApplier = null; // ล้างค่า MaterialApplier ที่ถูกคลิก
                    }
                }
            }
        }
    }

    private bool LookForGameObject(out RaycastHit hit)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        return Physics.Raycast(ray, out hit);
    }
}
