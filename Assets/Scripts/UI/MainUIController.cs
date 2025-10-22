using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Platformer.UI
{
    /// <summary>
    /// A simple controller for switching between UI panels.
    /// </summary>
    public class MainUIController : MonoBehaviour
    {
        public static MainUIController Instance { get; private set; }

        int enemyKillCounter = 0;
        int crystalCouter = 0;

        public GameObject[] panels;

        public TextMeshProUGUI enemyKIllCounterText;
        public TextMeshProUGUI crystalCouterText;

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void SetActivePanel(int index)
        {
            for (var i = 0; i < panels.Length; i++)
            {
                var active = i == index;
                var g = panels[i];
                if (g.activeSelf != active) g.SetActive(active);
            }
        }

        void OnEnable()
        {
            SetActivePanel(0);
        }

        public void UpdateEnemyKillCounter()
        {
            enemyKillCounter++;
            enemyKIllCounterText.text = "Enemy : " + enemyKillCounter.ToString();
        }

        public void UpdateCrystalCounter()
        {
            crystalCouter++;
            crystalCouterText.text = " : " + crystalCouter.ToString();
        }
    }
}