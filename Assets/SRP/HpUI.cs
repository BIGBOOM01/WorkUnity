using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpUI : MonoBehaviour
{
    public Text hpText;
    public PlayerController playerController;

    void Update()
    {
        UpdateHpText();
    }

    void UpdateHpText()
    {
        if (hpText != null && playerController != null)
        {
            hpText.text = "HP: " + GetCurrentHP().ToString();
        }
    }

    int GetCurrentHP()
    {
        // ตรวจสอบว่า playerController ไม่เป็น null ก่อนที่จะเรียก currentHP
        if (playerController != null)
        {
            return playerController.currentHP;
        }
        return 0; // หรือค่าอื่น ๆ ที่เหมาะสมหาก playerController ไม่พร้อมใช้งาน
    }
}
