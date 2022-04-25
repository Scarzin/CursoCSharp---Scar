﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoCSharp.API {
    public static class ExtensaoString {
        public static string ParseHome(this string path) {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }
    internal class PrimeiroArquivo {
        public static void Executar() {
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path)) {
                using (StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine("esse eh");
                    sw.WriteLine("nosso primeiro");
                    sw.WriteLine("arquivo!");
                }
            }

        }
    }
}