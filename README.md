# Uber-H3-for-Unity
<meta charset="utf-8">
<meta name="viewport" content="width=device-width, initial-scale=1">

<head>

<meta name="google-site-verification" content="2Z4Gh6jIDW5dUIaa0ttd_vOpny07lIq7_dOqD3za7vI" />
</head>
# Uber H3 for Unity

A pure C# implementation of Uber’s **H3 hexagonal geospatial indexing system**, fully compatible with **Unity** and **all platforms** — without any native plugins or external dependencies.

With this package you can generate, query, and work with H3 hex indexes directly in Unity for mapping, AR/VR, GIS, strategy games, simulations, and more.

---

## ✨ Features

- ✅ **Pure C# implementation** — no DLLs, no native plugins  
- ✅ **Works on all platforms** (Windows, Mac, Linux, Android, iOS, WebGL, Quest, etc.)  
- ✅ **Deterministic and fast** — based on Uber’s official H3 specification  
- ✅ **Perfect for geospatial projects** (GIS, heatmaps, GPS-based apps)  
- ✅ **Great for AR, VR, Mobile, and Mapping apps** in Unity  
- ✅ **Unity-friendly API**

---

## 📦 Installation (Recommended: UnityPackage Release)

1. Go to the **Releases** page:  
   👉 https://github.com/Artak-Gevorgyan-dev/Uber-H3-for-Unity/releases

2. Download the latest  
   **`Uber-H3-For-Unity.unitypackage`**

3. In Unity, import it via:  
   `Assets → Import Package → Custom Package…`

4. Done — the H3 API is now ready to use.

---

## 🚀 Quick Start (Geo → H3 Index)

```csharp
using H3.Model;
using H3.Units;

var lat = new Latitude(40.177200);   // Example: Yerevan
var lng = new Longitude(44.503490);
var res = Resolution.Res8;

H3Index index = H3Index.FromLatLong(lat, lng, res);
Debug.Log($"H3 Index: {index}");
