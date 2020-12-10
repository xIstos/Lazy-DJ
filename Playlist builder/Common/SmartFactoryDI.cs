using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist_builder.Common
{
    public class SmartFactoryDI
    {

            static SmartFactoryDI()
            {
                SingletoneLibrary = new ConcurrentDictionary<string, Object>();
                ObjectRelationLibrary = new ConcurrentDictionary<string, string>();
            }

            static ConcurrentDictionary<string, Object> SingletoneLibrary { get; set; }
            static ConcurrentDictionary<string, string> ObjectRelationLibrary { get; set; }

            static void Init()
            {
                throw new NotImplementedException();
            }
            public static T GetInstance<T>() where T : class
            {
                string key = typeof(T).AssemblyQualifiedName;
                if (ObjectRelationLibrary.ContainsKey(key))
                {
                    return Activator.CreateInstance(Type.GetType(ObjectRelationLibrary[key])) as T;
                }
                return null;
            }

            public static T GetInstance<T>(params object[] args) where T : class
            {
                string key = typeof(T).AssemblyQualifiedName;
                if (ObjectRelationLibrary.ContainsKey(key))
                {
                    return Activator.CreateInstance(Type.GetType(ObjectRelationLibrary[key]), args) as T;
                }
                return null;
            }

            public static T GetSingletone<T>() where T : class
            {
                string key = typeof(T).ToString();
                if (SingletoneLibrary.ContainsKey(key))
                {
                    return SingletoneLibrary[key] as T;
                }
                return null;
            }

            public static void AddSingletone<T>(T singletone) where T : class
            {
                SingletoneLibrary.TryAdd(typeof(T).ToString(), singletone);
            }



            public static void AddObjectRelation<T, I>() where T : class where I : class
            {
                ObjectRelationLibrary.TryAdd(typeof(T).AssemblyQualifiedName, typeof(I).AssemblyQualifiedName);
            }

            public static void AddObjectRelation(string abstractTypeName, string implementationTypeName)
            {
                ObjectRelationLibrary.TryAdd(abstractTypeName, implementationTypeName);
            }
        }
    }

