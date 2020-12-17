using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    
    public  int wave;

    [SerializeField]
    private GameObject Slime;
    [SerializeField]
    private GameObject Siur;

    [SerializeField]
    private GameObject Spawner1;
    [SerializeField]
    private GameObject Spawner2;
    private bool wywolano;
    private float x;
    // Start is called before the first frame update
    void Start()
    {
        wave = 0;
        wywolano = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.FindGameObjectWithTag("enemy"))
        {
            if (wywolano == false)
            {
                wave = wave + 1;
                if (wave % 1 == 0)
                {
                    Spawn2(Siur, wave / 1);
                }
            }
           doWave(wave);

        }
    }

    private void doWave(int fala)
    {
        if (wywolano == false)
        {
            wywolano = true;
            StartCoroutine(Spawn(Slime, fala));
        }
    }
    public IEnumerator Spawn(GameObject target,int fala)
    {
        for (int i = 0; i < fala*3; i++)
        {
            if (i % 2 == 0) { x = 29.53341f; } else { x = -30f; }
            yield return new WaitForSeconds(1);
            Instantiate(target, new Vector2(x,Random.Range(4f,-4f)), Quaternion.identity);
        }
        wywolano = false;

    }
    public void Spawn2(GameObject target, int fala)
    {
        for (int i = 0; i < fala; i++)
        {
            if (i % 2 == 0) { x = 29.53341f; } else { x = -30f; }
            Instantiate(target, new Vector2(x, Random.Range(4f, -4f)), Quaternion.identity);
        }
        wywolano = false;

    }
}
