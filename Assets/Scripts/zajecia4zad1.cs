using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zajecia4zad1 : MonoBehaviour
{
    public GameObject kostka;
    public int iloscKostek;
    List<Vector3> pozycje = new List<Vector3>();
    public Material material1;
    public Material material2;
    public Material material3;
    public Material material4;
    public Material material5;
    // Start is called before the first frame update
    void Start()
    {
        float platformaXFrom = transform.position.x - 5 * transform.localScale.x + 1;
        float platformaXTo = transform.position.x + 5 * transform.localScale.x;
        float platformaY = transform.position.y + (float)0.5;
        float platformaZFrom = transform.position.z - 5 * transform.localScale.z + 1;
        float platformaZTo = transform.position.z + 5 * transform.localScale.z;
        int licznik = 0;
        int powtorka;
        while (licznik != iloscKostek)
        {
            powtorka = 0;
            Vector3 jednaPozycja = new Vector3(Random.Range((int)platformaXFrom, (int)platformaXTo), platformaY, Random.Range((int)platformaZFrom, (int)platformaZTo));
            for (int i = 0; i < licznik; i++)
            {
                if (jednaPozycja == pozycje[i])
                {
                    powtorka++;
                }
            }
            if (powtorka == 0)
            {
                int caseSwitch = Random.Range(0, 5);
                switch (caseSwitch)
                {
                    case 0:
                        kostka.GetComponent<Renderer>().material = material1;
                        break;
                    case 1:
                        kostka.GetComponent<Renderer>().material = material2;
                        break;
                    case 2:
                        kostka.GetComponent<Renderer>().material = material3;
                        break;
                    case 3:
                        kostka.GetComponent<Renderer>().material = material4;
                        break;
                    case 4:
                        kostka.GetComponent<Renderer>().material = material5;
                        break;


                }
                
                Instantiate(kostka, jednaPozycja, Quaternion.identity);
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
