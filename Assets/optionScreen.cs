using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class optionScreen : MonoBehaviour
{

    public List<LevelItem> levels = new List<LevelItem>();
    private int selectedLevel;
    public TMP_Text levelLabel;

    public List<string> balls = new List<string>();
    private int selectedBall;
    public TMP_Text ballLabel;

    public List<string> mazes = new List<string>();
    private int selectedMaze;
    public TMP_Text mazeLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelLeft()
    {
        selectedLevel--;
        if (selectedLevel < 0)
        {
            selectedLevel = 0;
        }
        UpdateLevelLabel();
    }

    public void LevelRight()
    {
        selectedLevel++;
        if (selectedLevel > levels.Count - 1)
        {
            selectedLevel = levels.Count - 1;
        }
        UpdateLevelLabel();
    }

    public void UpdateLevelLabel()
    {
        levelLabel.text = levels[selectedLevel].difficulty.ToString();
    }


    public void BallLeft()
    {
        selectedBall--;
        if (selectedBall < 0)
        {
            selectedBall = 0;
        }
        UpdateBallLabel();
    }

    public void BallRight()
    {
        selectedBall++;
        if (selectedBall > balls.Count - 1)
        {
            selectedBall = balls.Count - 1;
        }
        UpdateBallLabel();
    }

    public void UpdateBallLabel()
    {
        ballLabel.text = balls[selectedBall];
    }


    public void MazeLeft()
    {
        selectedMaze--;
        if (selectedMaze < 0)
        {
            selectedMaze = 0;
        }
        UpdateMazeLabel();
    }

    public void MazeRight()
    {
        selectedMaze++;
        if (selectedMaze > mazes.Count - 1)
        {
            selectedMaze = mazes.Count - 1;
        }
        UpdateMazeLabel();
    }

    public void UpdateMazeLabel()
    {
        mazeLabel.text = mazes[selectedMaze];
    }


}

[System.Serializable]

public class LevelItem 
{
    public string difficulty;

}

