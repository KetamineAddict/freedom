﻿using System;
using System.Reflection;

namespace Freedom
{
    public struct ClassMethod
    {
        public ClassMethod(String c, String m, String n)
        {
            class_ = c;
            method = m;
            name = n;
        }

        public String class_ { get; set; }
        public String method { get; set; }
        public String name { get; set; }
    }

    public class PreJit
    {
        public static ClassMethod[] classmethods = new ClassMethod[]{
            new ClassMethod {class_ = "#=zYURwUP2uJSsqnTKodmJE03TyPLeq", method = "#=zatiWg0Szrt2L", name="beatmap_onload"},
            new ClassMethod {class_ = "#=zhFqy59fyDDU$w2YsO7z89QEc0IwbUUjvkJtJWu0=", method = "#=zpTKaeg$h_sSQy5vq$g==", name="selected_replay"},
        };

        public static int main(String pwzArgument)
        {
            var assembly = Assembly.GetEntryAssembly();
            Type[] classes = assembly.GetTypes();
            foreach (ClassMethod cm in classmethods)
            {
                foreach (Type class_ in classes)
                {
                    if (class_.Name == cm.class_)
                    {
                        MethodInfo[] methods = class_.GetMethods(
                                BindingFlags.DeclaredOnly |
                                BindingFlags.NonPublic |
                                BindingFlags.Public |
                                BindingFlags.Instance |
                                BindingFlags.Static);
                        foreach (MethodInfo method in methods)
                        {
                            if (method.Name == cm.method)
                            {
                                System.Runtime.CompilerServices.RuntimeHelpers.PrepareMethod(method.MethodHandle);
                                Console.WriteLine(String.Format("prejit {0} {1}::{2}", cm.name, cm.class_, cm.method));
                            }
                        }
                    }
                }
            }
            return 1;
        }
        public static int prejit_all(String pwzArgument)
        {
            Console.WriteLine("start prejit all");
            var assembly = Assembly.GetEntryAssembly();
            Type[] classes = assembly.GetTypes();
            foreach (Type class_ in classes)
            {
                MethodInfo[] methods = class_.GetMethods(
                        BindingFlags.DeclaredOnly |
                        BindingFlags.NonPublic |
                        BindingFlags.Public |
                        BindingFlags.Instance |
                        BindingFlags.Static);
                foreach (MethodInfo method in methods)
                {
                    foreach (ClassMethod cm in classmethods)
                    {
                        if (class_.Name.Length == cm.class_.Length && method.Name.Length == cm.method.Length)
                        {
                            try
                            {
                                System.Runtime.CompilerServices.RuntimeHelpers.PrepareMethod(method.MethodHandle);
                            } catch (Exception) {}
                        }
                    }
                }
            }
            Console.WriteLine("done prejit all");
            return 1;
        }
    }
}
