using System.Collections.Generic;
using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting.Antlr3.Runtime;

public class GridManager : MonoBehaviour
{
    [SerializeField] public Text _bedT;
    [SerializeField] public Text _closetT;
    [SerializeField] public Toggle _nigthstand;
    [SerializeField] public Text _sofaT;
    [SerializeField] public Toggle _stoolT;
    [SerializeField] public Text _table1x2T;
    [SerializeField] public Text _table2x2T;
    [SerializeField] public Text _rowsT;
    [SerializeField] public Text _colsT;
    [SerializeField] public GameObject ConfirmBtn;
    [SerializeField] public GameObject GenerateBtn;
    [SerializeField] public Text _message;
    [SerializeField] public GameObject _errMessageI;
    [SerializeField] public Canvas canvas;

    [SerializeField]
    private int Rows = 10, Cols = 10;
    [SerializeField]
    private float TileSize = 1;

    private int[,] Map;

    List<Furniture> _furnitures = new List<Furniture>();

    private void AddFurnitures()
    {
        for (int i = 0; i < int.Parse(_bedT.text); i++)
            _furnitures.Add(new Bed2x3());
        for (int i = 0; i < int.Parse(_closetT.text); i++)
            _furnitures.Add(new Closet2x1(2, 1));
        //for (int i = 0; i < int.Parse(_nigthstand.text); i++)
        //    _furnitures.Add(new Nightstand1x1(1, 1));
        for (int i = 0; i < int.Parse(_sofaT.text); i++)
            _furnitures.Add(new Sofa2x1(2, 1));
        //for (int i = 0; i < int.Parse(_stoolT.text); i++)
        //    _furnitures.Add(new Sofa2x1(2, 1));
        for (int i = 0; i < int.Parse(_table1x2T.text); i++)
            _furnitures.Add(new Table2x1(2, 1));
        for (int i = 0; i < int.Parse(_table2x2T.text); i++)
            _furnitures.Add(new Table2x2(2, 2));
    }

    private void GenerateGrid()
    {        
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
    }

    public void Confirm()
    {
        try
        {
            AddFurnitures();
            
        }
        catch (Exception ex)
        {
            _message.text = ex.Message;
            _errMessageI.SetActive(true);
            throw;
        }
        GenerateGrid();
        ConfirmBtn.SetActive(false);
    }

    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        ConfirmBtn.SetActive(true);
    }

    public void Generate()
    {
        GameObject RefTile = (GameObject)Instantiate(Resources.Load("plank_floor"));
        GameObject RefButton = (GameObject)Instantiate(Resources.Load("Button"));
        
        Rows = int.Parse(_rowsT.text);
        Cols = int.Parse(_colsT.text);
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                float posX = j * TileSize;
                float posY = i * -TileSize;

                if (i == 0 || j == 0 || i == Rows - 1 || j == Cols - 1)
                {
                    GameObject button = (GameObject)Instantiate(RefButton, transform);
                    button.transform.position = new Vector2(posX, posY);                   
                }

                GameObject tile = (GameObject)Instantiate(RefTile, transform);

                tile.transform.position = new Vector2(posX, posY);
                
            }

        }
        Destroy(RefTile);
        Destroy(RefButton);
        transform.position = new Vector2(-(Cols * TileSize) / 2 + TileSize, (Rows * TileSize) / 2 - TileSize / 2);
        transform.localScale = new Vector3(TileSize, TileSize, TileSize);
        GenerateBtn.SetActive(false);
    }

    public void ExeptionMessageExit()
    {
        _errMessageI.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        Map = new int[Rows, Cols];
        ConfirmBtn.SetActive(true);
        _errMessageI.SetActive(false);
    }
    
    // Update is called once per frame
    void Update()
    {

    }
}
