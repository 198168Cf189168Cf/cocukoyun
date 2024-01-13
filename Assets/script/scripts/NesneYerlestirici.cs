using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NesneYerlestirici : MonoBehaviour
{
    public GameObject[] dogruNesneler;
    public GameObject[] yanlisNesneler;
    void Start()
    {
        NesneleriGetir(); 
    }

   void NesneleriGetir()
    {
        List<GameObject> tumNesneler = new List<GameObject>();

        // "dogru" tag'ına sahip nesneleri ekle
        GameObject[] dogruNesneArray = GameObject.FindGameObjectsWithTag("dogru");
        tumNesneler.AddRange(dogruNesneArray);

        // "yanlis" tag'ına sahip nesneleri ekle
        GameObject[] yanlisNesneArray = GameObject.FindGameObjectsWithTag("yanlis");
        tumNesneler.AddRange(yanlisNesneArray);

        // Nesneleri karıştır
        Shuffle(tumNesneler);

        // Sahneye rastgele bir nesne yerleştir
        if (tumNesneler.Count > 0)
        {
            GameObject secilenNesne = tumNesneler[Random.Range(0, tumNesneler.Count)];
            Instantiate(secilenNesne, transform.position, Quaternion.identity);
        }
        else
        {
            Debug.LogError("Sahneye yerleştirilecek nesne bulunamadı!");
        }
    }

    void Shuffle<T>(List<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}
