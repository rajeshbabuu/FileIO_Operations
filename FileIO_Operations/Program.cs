﻿namespace FileIO_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File Input-Output Operation");

            Operations obj = new Operations();
            obj.FileExists();
            obj.ReadAllLines();
            obj.ReadAllText();
        }
    }
}