using UnityEngine;

public class CrashBlock : MonoBehaviour
{
    public float m_Strength = 1, m_hp = 1;

    void OnCollisionEnter2D(Collision2D col)
    {
        float damage = col.relativeVelocity.magnitude - m_Strength;
        if (damage > 0)
        {
            m_hp -= damage;
        }

        if (m_hp < 0)
        {
            Destroy(gameObject);
        }
    }
}