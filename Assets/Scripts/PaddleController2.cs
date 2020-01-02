using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController2 : MonoBehaviour
{
    public int kecepatan = 7;
    public string axis = "Vertical2";
    public double batasAtas = 2.8;
    public double batasBawah = -2.8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float gerak = Input.GetAxis(axis) * kecepatan * Time.deltaTime;
        float nextPos = transform.position.y + gerak;
        if (nextPos > batasAtas) {
            gerak = 0;
        }
        if (nextPos < batasBawah) {
            gerak = 0;
        }
        transform.Translate(0, gerak, 0);
    }
}
