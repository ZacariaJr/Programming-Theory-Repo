using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jump_Height = 10f;
    public SpriteRenderer sr;

    public Color yellow_Color;
    public Color cyan_Color;
    public Color magenta_Color;
    public Color red_Color;

    public string current_Color;

    // Start is called before the first frame update
    void Start()
    {
        SetRandom_Color();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Jump_Ball();
        }
    }

    void Jump_Ball()
    {
        Vector2 vel = rb.velocity;
        vel.y = jump_Height;
        rb.velocity = vel;
    }


    void SetRandom_Color()
    {
        int index = Random.Range(0, 4);

        if (index == 0)
        {
           sr.color = magenta_Color;
            current_Color = "Magenta";
        }
        else if (index == 1)
        {
           sr.color = yellow_Color;
            current_Color = "Yellow";
        }
        else if (index == 2)
        {
            sr.color = cyan_Color;
            current_Color = "Cyan";
        }
        else if (index == 3)
        {
            sr.color = red_Color;
            current_Color = "Dark_Red";
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Color_Changer")
        {
            SetRandom_Color();
            Destroy(other.gameObject);
            return;
        }

        if (current_Color != other.tag)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
    }

}
