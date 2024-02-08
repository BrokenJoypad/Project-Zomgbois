using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody m_Rigidbody;
    private PlayerStats m_PlayerStats;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_PlayerStats = GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKey(KeyCode.W))
        {
            Vector3 m_Input = new Vector3(+1, 0, 0);
            m_Rigidbody.MovePosition(transform.position + m_Input * Time.deltaTime * m_PlayerStats.ReturnPlayerSpeed());
        } 
     
     if(Input.GetKey(KeyCode.S))
        {
            Vector3 m_Input = new Vector3(-1, 0, 0);
            m_Rigidbody.MovePosition(transform.position + m_Input * Time.deltaTime * m_PlayerStats.ReturnPlayerSpeed());

        }
     if(Input.GetKey(KeyCode.A))
        {
            Vector3 m_Input = new Vector3(0, 0, +1);
            m_Rigidbody.MovePosition(transform.position + m_Input * Time.deltaTime * m_PlayerStats.ReturnPlayerSpeed());

        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 m_Input = new Vector3(0, 0, -1);
            m_Rigidbody.MovePosition(transform.position + m_Input * Time.deltaTime * m_PlayerStats.ReturnPlayerSpeed());

        }

        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        {
            Vector3 m_Input = new Vector3(+1, 0, +1);
            m_Rigidbody.MovePosition(transform.position + m_Input * Time.deltaTime * m_PlayerStats.ReturnPlayerSpeed());
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
        {
            Vector3 m_Input = new Vector3(-1, 0, -1);
            m_Rigidbody.MovePosition(transform.position + m_Input * Time.deltaTime * m_PlayerStats.ReturnPlayerSpeed());

        }

         if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
        {
            Vector3 m_Input = new Vector3(+1, 0, -1).normalized;
            m_Rigidbody.MovePosition(transform.position + m_Input * Time.deltaTime * m_PlayerStats.ReturnPlayerSpeed());
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
        {
            Vector3 m_Input = new Vector3(-1, 0, +1).normalized;
            m_Rigidbody.MovePosition(transform.position + m_Input * Time.deltaTime * m_PlayerStats.ReturnPlayerSpeed());
        }

    }
}
