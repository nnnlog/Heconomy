﻿
/*
    ooooo   ooooo                     .o8        .ooooo.   
    `888'   `888'                    "888       888' `Y88. 
     888     888   .ooooo.  oooo d8b  888oooo.  888    888 
     888ooooo888  d88' `88b `888""8P  d88' `88b  `Vbood888 
     888     888  888ooo888  888      888   888       888' 
     888     888  888    .o  888      888   888     .88P'  
    o888o   o888o `Y8bod8P' d888b     `Y8bod8P'   .oP'     

    Directed by Herb9.
*/

using MiNET;

using MiNET.Plugins;

using MiNET.Worlds;

using System.Linq;
using System.IO;
using System;
using System.Reflection;

namespace Heconomy
{

    public class Heconomy
    {

        public const string Prefix = "\x5b\x48\x65\x63\x6f\x6e\x6f\x6d\x79\x5d";

        public static Heconomy GetAPI()
        {
            return new Heconomy();
        }

        public string GetPluginFolder()
        {
            return Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase)).LocalPath, "Heconomy");
        }

        public string GetMoneySymbol()
        {
            return "$";
        }

        public float GetDefaultMoney()
        {

        }

        public float GetMoney(string player)
        {
            return (float) 1;
        }

        public void SetMoney(string player, float amount)
        {

        }

        public bool IsRegisteredPlayer(string player)
        {

        }

        public void RegisterPlayer(Player player)
        {
            string data = GetPluginFolder() + "\\players\\" + player.Username.ToLower() + ".dat";
            File.Create(data);
        }

        public Player GetNameByPlayer(string player, Level level)
        {
            return level.Players.ToList().Find(x => x.Value.Username == player).Value ?? null;
        }
    }
}
