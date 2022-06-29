using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using H3Lib;
using UnityEngine.UI;

public class H3Controller : MonoBehaviour
{
    [SerializeField]
    private InputField Latitude;
    [SerializeField]
    private InputField Longitude;
    [SerializeField]
    private InputField Resolution;
    [SerializeField]
    private Text Result;

    private decimal _lat;
    private decimal _lon;
    private int _res;

    public void GetH3()
    { 

        _lat = System.Convert.ToDecimal(float.Parse(Latitude.text) * Mathf.Deg2Rad);
        _lon = System.Convert.ToDecimal(float.Parse(Longitude.text) * Mathf.Deg2Rad);
        _res = int.Parse(Resolution.text);
        var _geo = new GeoCoord(_lat, _lon);
        var _h3 = Api.GeoToH3(_geo, _res);
        Result.text = _h3.ToString();
    }


}
