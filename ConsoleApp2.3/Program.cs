﻿using System;
namespace ConsoleApp2._3;

public class Program
{
    static void Main(string[] args)
    {
        Worker tom = new Worker("Tom", "Ysachev", 2000, 30);
        tom.Get_Salary();
    }
}