using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderboardController : MonoBehaviour

     
{

    public static LeaderboardController Instance;

    public List<int> numberList;
    public List<int> scoreList;
    public List<string> nameList;
    public string player;
    private int rankingText;
    private string gradeText;
    public ScoreController sc;
    public PrimarySurveyController psc;

    public GameObject lbp;


    void Awake()
    {
        // Singleton pattern
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else if (Instance != this)
        {
            Destroy(Instance.gameObject);
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }




    private int totalScore;
    // Start is called before the first frame update
    void Start()
    {
       
        //numberList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        scoreList = new List<int> { 8000, 8500, 7000, 6000, 5000, 5500, 4000 };
        nameList = new List<string> { "NICHOLAS", "JENNIFER", "IKUN", "JOHN", "JETCHOO", "KENNY", "GWEN" };

        player = StaticData.valueToKeep;

        if (player != null)
        {
            totalScore = totalScore = sc.getScore() + psc.getBonusScore() + 333;
            addUserScore(totalScore, player);
            determineRanking();
            rankingText = rankingText + 1;
            determineGrade();
        }

        int i = 1;
        foreach (string name in nameList)
        {
            numberList.Add(i++);
        }

        PassDataToStartMenu.numberList = numberList;
        PassDataToStartMenu.nameList = nameList;
        PassDataToStartMenu.scoreList = scoreList;


        StartCoroutine(activatelbp());
    }

    public void addUserScore(int userScore, string player)
    {
        int indexToInsert = 0;
        while (userScore < scoreList[indexToInsert])
        {
            indexToInsert++;
            Debug.Log(indexToInsert + "and " + userScore);
        }

        scoreList.Insert(indexToInsert, userScore);
        nameList.Insert(indexToInsert, player);

    }

    public void determineRanking()
    {
        int rankingText = nameList.IndexOf(player);
        Debug.Log(nameList.IndexOf(player));
        //rankingText = 2;
        //rankingText = numberList[index];
    }

    public void determineGrade()
    {
        if (totalScore >= 9000)
        {
            gradeText = "A";
        }
        else if (totalScore >= 7000)
        {
            gradeText = "B";
        }
        else
        {
            gradeText = "C";
        }
    }

    public string getPlayerName()
    {
        return player;
    }
    public int getTotalScore()
    {
        return totalScore;
    }
    
    public int getRanking()
    {
        return rankingText;
    }

    public string getGrade()
    {
        return gradeText;
    }
    public List<int> getNumberList()
    {
         
         return numberList;
    }
    public List<string> getNameList()
    {
        return nameList;
    }

    public List<int> getScoreList()
    {
      
        return scoreList;
    }

    IEnumerator activatelbp()
    {
        yield return new WaitForSeconds(0.1f);
        lbp.SetActive(true);
    }
}
