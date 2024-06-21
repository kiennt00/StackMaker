using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : Singleton<LevelManager>
{
    public List<Level> levels = new();
    public Level currentLevel;
    public int currentLevelIndex;
    public int highestLevel;

    private void Start()
    {
        highestLevel = GetHighestLevel();
    }

    public void OnLoadLevel(int levelIndex)
    {
        if (currentLevel != null)
        {
            Destroy(currentLevel.gameObject);
        }

        if (levelIndex < levels.Count)
        {
            currentLevelIndex = levelIndex;
            currentLevel = Instantiate(levels[levelIndex]);
            currentLevel.InitLevel();
        }        
    }

    public void PlayAgain()
    {
        OnLoadLevel(currentLevelIndex);
    }

    public void NextLevel()
    {
        currentLevelIndex++;
        
        if (currentLevelIndex < levels.Count)
        {
            OnLoadLevel(currentLevelIndex);

            if (highestLevel < currentLevelIndex)
            {
                highestLevel = currentLevelIndex;
                PlayerPrefs.SetInt("highestLevel", highestLevel);
            }
        }
        else
        {
            Debug.Log("Congrats");
        }       
    }

    public int GetHighestLevel()
    {
        return PlayerPrefs.GetInt("highestLevel", 0);
    }
}
