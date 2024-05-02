using UnityEngine;

public class Block : MonoBehaviour
{
    public GameObject[] tilePrefabs; // อาเรย์ของ Prefab แผ่นพื้นต่างๆที่เลือก

    void Start()
    {
        // เรียกใช้ฟังก์ชันสุ่ม Prefab เมื่อเริ่มเกม
        RandomizeTile();
    }

    void RandomizeTile()
    {
        // สุ่มตัวเลขเพื่อเลือก Prefab แผ่นพื้น
        int randomIndex = Random.Range(0, tilePrefabs.Length);
        
        // สร้าง Prefab แผ่นพื้นที่สุ่มมาและเก็บ reference
        GameObject selectedTile = Instantiate(tilePrefabs[randomIndex], transform.position, Quaternion.identity);
        
        // เปลี่ยน parent ของ Prefab ที่สร้างใหม่เป็น parent ของ Tile
        selectedTile.transform.parent = transform;
    }
}
