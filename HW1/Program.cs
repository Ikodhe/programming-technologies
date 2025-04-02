﻿using System;
using System.Threading.Tasks;
using Hw1;

namespace Programs
{
    class Program
    {
        static void Main(string[] args)
        {


            var factories = Factories.GetFactories();
            var units = Units.GetUnits(factories);
            var tank = Tank.GetTanks(units);

            Console.WriteLine($" \t\t   Id \t\t\t   Name \t\t    Description");
            foreach (Factories fact in factories)
            {
                Console.WriteLine($" {fact.IdFactories} \t {fact.Name} \t {fact.Description} ");
            }
            Console.WriteLine();
            Console.WriteLine($" \t\tId\t\t\tName\t\tDescription\t\t\t IdFactories");

            foreach (Units unit in units)
            {
                Console.WriteLine($" {unit.IdUnits} \t {unit.Name} \t {unit.Description} \t {unit.IdFactories} ");
            }
            Console.WriteLine();
            Console.WriteLine($" \t\tId \t\t\t  Name\t\t\tDescription\t\tVolume  MaxVolume \t\t IdUnits");
            foreach (Tank t in tank)
            {
                Console.WriteLine($" {t.IdTank} \t {t.Name} \t {t.Description} \t {t.Volume} \t {t.MaxVolume} \t {t.IdUnits}");
            }
            Console.WriteLine();

            Console.WriteLine($"Количество резервуаров: {tank.Length}, установок: {units.Length}");


        }
    }
}