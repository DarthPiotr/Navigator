using System;
using System.Diagnostics;
using System.Reflection;
using Xamarin.Forms;

namespace Navigator
{
    public static class Utils
    {
        public static T GetElementByName<T> (string name)
        {
            try
            {
                var lab = Application.Current.MainPage.FindByName(name);

                if (lab is T typeObj)
                {
                    Debug.WriteLine("I: Searching for name: {0}; found: ({2}){1}", name, lab.ToString(), typeof(T));
                    return typeObj;
                }
                else
                {
                    if (lab != null)
                        Debug.WriteLine("E: Searching for name: {0}; found: {1}, which is not type {2}", name, lab.ToString(), typeof(T));
                    else
                        Debug.WriteLine("E: Searching for name: {0}; found: null", name);
                    return default(T);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("An error occured: " + ex.Message);
            }
            return default(T);
        }

        public static string GetNamespacePrefix<T>()
        {
            if (typeof(T).GetTypeInfo().Assembly.GetName().Name == "Navigator.Android")
                return "NavigatorV2.Droid";
            else
                return "Navigator.iOS";
        }

        public static class Values
        {
            public static readonly double DEFAULT_LATITUDE = 52.668174;
            public static readonly double DEFAULT_LONGITUDE = 19.042817;
            public static readonly double DEFAULT_DISTANCE_METERS = 80;
            public static readonly float DEFAULT_BEARING = 32;
            public static readonly float DEFAULT_ZOOM = 17;
            public static readonly float DEFAULT_TILT = 0;
        }
    }
}
