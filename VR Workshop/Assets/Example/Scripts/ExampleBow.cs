using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleBow : MonoBehaviour
{
    public Transform m_string;
    public Transform m_stringStart;
    public float m_shootForce = 1000f;

    public GameObject m_prefabArrow;
    
    private GameObject m_nockedArrow;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            m_nockedArrow = Instantiate(m_prefabArrow, transform.position, transform.rotation);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            m_string.position = other.transform.position;
            m_nockedArrow.transform.position = other.transform.position;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            m_shootForce = Vector3.Distance(m_string.position, m_stringStart.position) * m_shootForce;
            m_string.position = m_stringStart.position;
            m_nockedArrow.GetComponent<Rigidbody>().isKinematic = false;
            m_nockedArrow.GetComponent<Rigidbody>().AddForce(transform.forward);
            Destroy(m_nockedArrow, 5f);
        }
    }
}
