using System;
using TMPro;
using UnityEngine;

namespace TestCodes
{
    public class TotalCoinDisplayer:MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI coinText;
        [SerializeField] private int coinCount = 4;

        private void OnEnable()
        {
            coinText.text = "Total Coin: " + coinCount;
        }
        public void IncreaseCoin(Component sender, object coinData)
        {
            coinCount += (int) coinData;
            coinText.text = "Total Coin: " + coinCount;
        }
    }
}