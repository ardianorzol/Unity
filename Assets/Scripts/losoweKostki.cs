using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class losoweKostki : MonoBehaviour
{
    public GameObject kostka;
    
    List<Vector3> pozycje = new List<Vector3>();
    // Start is called before the first frame update
    void Start()
    {
        int licznik = 0;
        int powtorka;
        while (licznik != 10)
        {
            powtorka = 0;
            Vector3 jednaPozycja = new Vector3(Random.Range(1, 10), 0.5f, Random.Range(1, 10));
            for(int i=0; i<licznik; i++)
            {
                if( jednaPozycja == pozycje[i])
                {
                    powtorka++;
                }
            }
            if(powtorka == 0)
            {
                Instantiate(this.kostka, jednaPozycja, Quaternion.identity);
                licznik++;
                pozycje.Add(jednaPozycja);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
