using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleShoot : MonoBehaviour
{
    public GameObject m_prefabObject;
    public float m_shootForce = 500f;
    public string m_trigger;
    private bool m_triggerHeld;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis(m_trigger) > 0.5f && !m_triggerHeld == false)
        {
            m_triggerHeld = true;
            GameObject go = Instantiate(m_prefabObject, transform.position, transform.rotation);
            go.GetComponent<Rigidbody>().AddForce(transform.forward * m_shootForce);
        }
        else if (Input.GetAxis(m_trigger) < 0.5f && m_triggerHeld == true)
        {
            m_triggerHeld = false;
        }
    }
}
