using UnityEngine;

namespace LlamAcademy
{
    public class UnitMonoBehaviour : MonoBehaviour
    {
        public int Damage = 6;
        public float AttackSpeed = 0.25f;
        public string DisplayName = "Llama";
        public Sprite Icon;
        public int Health = 40;
        public int WeaponUpgrades = 0;
        public int ArmorUpgrades = 0;
    }
}
