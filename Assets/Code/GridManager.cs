using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField]
    private int Rows = 5, Cols = 5;
    [SerializeField]
    private float TileSize = 1;


    private void GenerateGrid()
    {
        GameObject RefTile = (GameObject)Instantiate(Resources.Load("plank_floor"));
        GameObject RefOk = (GameObject)Instantiate(Resources.Load("yes-png-9"));
        GameObject Man = (GameObject)Instantiate(Resources.Load("man"));

        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                float posX = j * TileSize;
                float posY = i * -TileSize;

                if(i == 4 && j == 4)
                {
                    GameObject man = (GameObject)Instantiate(Man, transform);

                    man.transform.position = new Vector2(posX, posY);
                    man.transform.Rotate(0.0f, 0.0f, -90.0f);
                    man.transform.position = new Vector2(posX-1, posY);
                    man.transform.TransformDirection(-1.0f, -1.0f, 1.0f);
                }
                /*GameObject ok = (GameObject)Instantiate(RefOk, transform);

                ok.transform.position = new Vector2(posX, posY);*/


                GameObject tile = (GameObject)Instantiate(RefTile, transform);


                tile.transform.position = new Vector2(posX, posY);
            }

        }
        Destroy(RefTile);
        Destroy(RefOk);
        Destroy(Man);

        transform.position = new Vector2(-(Cols * TileSize) / 2 + TileSize, (Rows * TileSize) / 2 - TileSize / 2);
        transform.localScale = new Vector3(TileSize, TileSize, TileSize);
    }


    // Start is called before the first frame update
    void Start()
    {
        GenerateGrid();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
