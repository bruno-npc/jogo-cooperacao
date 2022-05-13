using UnityEngine;


public class GenerateLevel : MonoBehaviour
{
public Texture2D map;
public Color[] Cores;
public GameObject[] Prefab;

void Start() {
    GLevel();
}

void GLevel() {

     for(int x = 0; x < map.width; x++){
               for(int y = 0; y < map.height; y++){
                    GenerateTile(x,y);
               }
     }
}

void GenerateTile(int x, int y){

     Color PixelColor = map.GetPixel(x,y);

     for(int i = 0; i < Cores.Length; i++) {
         if(Cores[i] == PixelColor){
              Instantiate(Prefab[i], new Vector2(x,y), Quaternion.identity, transform);
         }
     }
}
}