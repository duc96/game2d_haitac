using UnityEngine;
using UnityEngine.UI;

public class controller : MonoBehaviour
{
    
    public Animator anim;
    public bool gold = false;
    public bool nen = false;
    public bool chem = false;
    public Rigidbody2D rigidbody2D;
    public GameObject gameObject;
    public Collider2D one;
    public congDiem add;

    void Start()

    {

        anim = GetComponent<Animator>();

        rigidbody2D = GetComponent<Rigidbody2D>();

        add = GameObject.FindWithTag("diem").GetComponent<congDiem>();

    }

    void OnTriggerEnter2D(Collider2D other)

    {

        if (other.gameObject.tag == "kill_top")

        {
            Debug.Log("va cham");
            chem = true;
        }

        if (other.gameObject.tag == "gold")
        {
            gold = true;
            Debug.Log("vang");
        }

    }

    void OnCollisionEnter2D(Collision2D con)

    {
        if (con.gameObject.tag == "nen")

        {
            nen = true;
        }
        
    }

    void Update()
    {
        if(gold == true)
        {
            Destroy(GameObject.FindGameObjectWithTag("gold"));
            add.tangDiem();
            gold = false;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {

            transform.Translate((Time.deltaTime) * 4, 0, 0);

            transform.localScale = new Vector3(0.2f, 0.2f, 0);

            anim.SetBool("isWalking", true);

            anim.Play("walk");

            anim.SetBool("isWalking", false);

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            transform.Translate(-(Time.deltaTime) * 4, 0, 0);

            transform.localScale = new Vector3(-0.2f, 0.2f, 0);

            anim.SetBool("isWalking", true);

            anim.Play("walk");

            anim.SetBool("isWalking", false);
            
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (nen == true)
            {

                rigidbody2D.AddForce(Vector2.up * 500f);

                anim.SetBool("isJumping", true);

                anim.Play("jump");

                anim.SetBool("isJumping", false);

                nen = false;

            }

        }

        if (Input.GetKeyDown(KeyCode.Q))
        {

            anim.SetBool("isAttacking", true);

            anim.Play("attack");

            anim.SetBool("isAttacking", false);

            Debug.Log("chem");

            if (chem == true)
            {
                Debug.Log("chem roi");

                add.tangDiem();

                Destroy(GameObject.Find("dich"), 0.6f);

                chem = false;
            }
        }
    }
}