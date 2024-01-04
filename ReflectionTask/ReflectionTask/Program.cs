﻿using ReflectionTask.Models;
using ReflectionTask.Services;

namespace ReflectionTask {
    public class Program
    {
        static void Main(string[] args)
        {

            Employee e = new("Ayush", 23, "12344", 23000, "SDE", "SD1");
            string path = @"C:\Users\ayush\Desktop\htmldata.txt";

            FileOperationsService.PopulateDataToFile(e , path);
        }

    }
}