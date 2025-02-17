﻿using Okolni.Source.Query;
using System;
using System.Linq;

namespace Okolni.Source.Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            IQueryConnection conn = new QueryConnection();

            conn.Host = "127.0.0.1";
            conn.Port = 27015;

            conn.Connect();

            var info = conn.GetInfo();
            Console.WriteLine($"Server info: {info.ToString()}");
            var players = conn.GetPlayers();
            Console.WriteLine($"Current players: {string.Join("; ", players.Players.Select(p => p.Name))}");
            var rules = conn.GetRules();
            Console.WriteLine($"Rules: {string.Join("; ", rules.Rules.Select(r => $"{r.Key}: {r.Value}"))}");
        }
    }
}
