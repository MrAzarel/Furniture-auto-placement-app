using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField]
    private int Rows = 5, Cols = 5;
    [SerializeField]
    private float TileSize = 1;

    private int[,] Map;


    private void GenerateGrid()
    {
        GameObject RefTile = (GameObject)Instantiate(Resources.Load("plank_floor"));
        GameObject Bed = (GameObject)Instantiate(Resources.Load("Bed"));
        GameObject Closet = (GameObject)Instantiate(Resources.Load("Closet"));
        GameObject Table = (GameObject)Instantiate(Resources.Load("Table2x2"));
        GameObject Stool = (GameObject)Instantiate(Resources.Load("Stool"));
        GameObject Sofa = (GameObject)Instantiate(Resources.Load("Sofa2x1"));
        GameObject Man = (GameObject)Instantiate(Resources.Load("Man"));


        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                float posX = j * TileSize;
                float posY = i * -TileSize;

                GameObject tile = (GameObject)Instantiate(RefTile, transform);


                tile.transform.position = new Vector2(posX, posY);
            }

        }
        Destroy(RefTile);

        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                float posX = j * TileSize;
                float posY = i * -TileSize;

                if(i == 4 && j == 3)
                {
                    GameObject bed = (GameObject)Instantiate(Bed, transform);
                    GameObject man = (GameObject)Instantiate(Man, transform);
                    bed.transform.position = new Vector2(posX, posY);
                    man.transform.position = new Vector2(posX, posY + 1);

                    /*man.transform.Rotate(0.0f, 0.0f, -90.0f);
                    man.transform.position = new Vector2(posX-1, posY);
                    man.transform.TransformDirection(-1.0f, -1.0f, 1.0f);*/
                }
                if (i == 4 && j == 1)
                {
                    GameObject closet = (GameObject)Instantiate(Closet, transform);

                    closet.transform.position = new Vector2(posX, posY);
                }

                if (i == 2 && j == 1)
                {
                    GameObject table2x2 = (GameObject)Instantiate(Table, transform);

                    table2x2.transform.position = new Vector2(posX, posY);
                }

                if (i == 3 && j == 1)
                {
                    GameObject stool = (GameObject)Instantiate(Stool, transform);

                    stool.transform.position = new Vector2(posX, posY);
                }

                if (i == 0 && j == 0)
                {
                    GameObject sofa = (GameObject)Instantiate(Sofa, transform);

                    sofa.transform.position = new Vector2(posX, posY);
                }
            }

        }
        Destroy(Bed);
        Destroy(Closet);
        Destroy(Table);
        Destroy(Stool);
        Destroy(Sofa);
        Destroy(Man);

        transform.position = new Vector2(-(Cols * TileSize) / 2 + TileSize, (Rows * TileSize) / 2 - TileSize / 2);
        transform.localScale = new Vector3(TileSize, TileSize, TileSize);
    }


    // Start is called before the first frame update
    void Start()
    {
        Map = new int[Rows, Cols];
        GenerateGrid();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
