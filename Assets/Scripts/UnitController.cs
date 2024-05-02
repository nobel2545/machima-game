using UnityEngine;

public class UnitMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // ความเร็วในการเคลื่อนที่ของยูนิต

    private void Update()
    {
        if (Input.GetMouseButton(0)) // ตรวจสอบว่ามีการคลิกเมาส์ซ้ายหรือไม่
        {
            // สร้าง Ray จากตำแหน่งของเมาส์
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // ตรวจสอบว่า Ray ชนขอบกริดหรือไม่
            if (Physics.Raycast(ray, out hit))
            {
                // ได้ตำแหน่งบนกริดที่ชน
                Vector3 targetPosition = hit.point;

                // ย้ายตำแหน่งของยูนิตไปยังตำแหน่งที่ชน
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            }
        }
    }
}
