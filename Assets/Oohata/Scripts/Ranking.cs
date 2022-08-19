using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;


public class Ranking : MonoBehaviour
{
    private static int[] _top5 = new int[5] { 0, 0, 0, 0, 0 };
    public static int _Score = 0;

    [SerializeField]
    Text[] _Rankin;


    void Start()
    {
        var _rankingList = _top5.ToList<int>();
        _rankingList.Add(_Score);

        var _rankin = _rankingList.OrderByDescending(r => r).Take(_top5.Length).ToList();



        for (var i = 0; i < _rankin.Count; i++)
        {

            _Rankin[i].text = ($"{i + 1}ˆÊ:{_rankin[i]}");
        }

    }
}
