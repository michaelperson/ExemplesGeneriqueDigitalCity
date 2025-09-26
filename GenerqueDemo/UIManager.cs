using GenerqueDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GenerqueDemo
{
    internal static class UIManager
    {
        //simple méthode générique
        /// <summary>
        /// Permet d'afficher les informations d'un objet
        /// </summary>
        /// <typeparam name="T">type de paramètre contraint! ça doit être une class avec un constructeur parameterless et implémenter l'interface IViewable</typeparam>
        /// <param name="obj">l'objet que nous désirons afficher dans programm</param>
        public static void DisplayInfo<T>(T obj)
            where T : class, IViewable, new() 
        {
            Console.WriteLine(obj.getView());
        }

        /// <summary>
        /// Version sans générique et fonctionnel
        /// </summary>
        /// <param name="obj">l'objet que nous désirons afficher dans programm</param>
        public static void DisplayInfo(IViewable obj) 
        {
            Console.WriteLine(obj.getView());
        }
        /// <summary>
        /// Version sans générique et fonctionnel MAIS comme on utilise le type object, on laisse la porte ouverte à n'importe quel type donc nous ne pouvons utiliser que les méthodes de Object
        /// </summary>
        /// <param name="obj">l'objet que nous désirons afficher dans programm</param>
        public static void DisplayInfoObj(Object obj)
        {
            Console.WriteLine(obj.ToString());
        }


        //Générique + réflexion
        //!!!!!! La reflection consomme beaucoup de ressource !!!!
        // A n'utiliser qu'après avoir réfléchi :)
        public static MonTypeGenerique Usine<MonTypeGenerique>(Dictionary<string, Object> infos)
            where MonTypeGenerique :  new()
        {
            MonTypeGenerique a;

            //constuire mon objet
            a = new MonTypeGenerique();            
            Type leTypeReel = typeof(MonTypeGenerique);
            PropertyInfo[] lesPropprietes = leTypeReel.GetProperties();
            foreach (KeyValuePair<string,object> item in infos)
            {
                foreach (PropertyInfo p in lesPropprietes)
                {
                    //est que le Name de la propertyInfo est = à la clé du dictionnaire
                    // property Item => name:birthdate
                    // dictionnaire key ==> birthdate
                    if(p.Name== item.Key)
                    {
                        p.SetValue(a, item.Value);
                    }
                }
            }
            //renvoyer mon objet
            return a;
        }

    }
}
