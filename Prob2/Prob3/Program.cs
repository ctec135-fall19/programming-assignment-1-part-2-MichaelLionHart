/*
Author:     Mike Hart
Date:       10/9/19
CTEC 135:   Microsoft Software Development with C#
<Module 2,  Programming Assignment 1 part 2 , Problem 3>   
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region part 1 - nested for loops
            // three nested for loops to check each of the three conditions
            Console.WriteLine("-------------------------------------------" +
                "--------------------------------");
            Console.WriteLine("                   Part One - 3 nested for loops:");
            Console.WriteLine("-------------------------------------------" +
                "--------------------------------");
            Console.WriteLine();
            for (int printerPrints = 0; printerPrints < 2; printerPrints++)
            {
                for (int redLight = 0; redLight < 2; redLight++)
                {
                    for (int printerRecognized = 0; printerRecognized < 2; 
                        printerRecognized++)
                    {   // decision constructs for printing out conditions
                        if (printerPrints == 0)
                        {
                            Console.WriteLine("----------------------------" +
                                "--------------");
                            Console.WriteLine();
                            Console.WriteLine("Conditions:");
                            Console.WriteLine();
                            Console.WriteLine("Prints:\t\t\t False ");
                        } else
                        {
                            Console.WriteLine("---------------------------" +
                                "---------------");
                            Console.WriteLine();
                            Console.WriteLine("Conditions:");
                            Console.WriteLine();
                            Console.WriteLine("Prints:\t\t\t True ");
                        }

                        if (redLight == 0)
                        {
                            Console.WriteLine("Flashing light:\t\t False ");                            
                        }
                        else
                        {
                            Console.WriteLine("Flashing light:\t\t True ");                            
                        }

                        if (printerRecognized == 0)
                        {
                            Console.WriteLine("Printer recognized:\t False ");
                            Console.WriteLine();
                            Console.WriteLine("Possible Actions:");
                        }
                        else
                        {
                            Console.WriteLine("Printer recognized:\t True ");
                            Console.WriteLine();
                            Console.WriteLine("Possible Actions:");
                        }

                        // decision constructs for printing out actions 
                        // (calling methods)
                        if (printerPrints == 0 && redLight == 1 && printerRecognized == 0)
                        {
                            PrinterCable();
                            PrinterSoftware();
                            CheckInk();
                            Console.WriteLine();
                            Console.WriteLine();                            
                        }

                        if (printerPrints == 0 && redLight == 1 && printerRecognized == 1)
                        {                            
                            CheckInk();
                            PaperJam();
                            Console.WriteLine();
                            Console.WriteLine();
                        }

                        if (printerPrints == 0 && redLight == 0 && printerRecognized == 0)
                        {
                            PowerCable();
                            PrinterCable();
                            PrinterSoftware();
                            Console.WriteLine();
                            Console.WriteLine();
                        }

                        if (printerPrints == 0 && redLight == 0 && printerRecognized == 1)
                        {
                            PaperJam();
                            Console.WriteLine();
                            Console.WriteLine();
                        }

                        if (printerPrints == 1 && redLight == 1 && printerRecognized == 0)
                        {
                            PrinterSoftware();
                            Console.WriteLine();
                            Console.WriteLine();
                        }

                        if (printerPrints == 1 && redLight == 1 && printerRecognized == 1)
                        {
                            CheckInk();
                            Console.WriteLine();
                            Console.WriteLine();
                        }

                        if (printerPrints == 1 && redLight == 0 && printerRecognized == 0)
                        {
                            PrinterSoftware();
                            Console.WriteLine();
                            Console.WriteLine();
                        }

                        if (printerPrints == 1 && redLight == 0 && printerRecognized == 1)
                        {
                            Console.WriteLine("N/A");
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                    }
                }
            }
            #endregion

            #region part 2 - for loop with switch statement
            // second part of assignment - for loop with switch statement
            Console.WriteLine("--------------------------------------------" +
                "-------------------------------");
            Console.WriteLine("            Part Two - for loop with " +
                "switch statement:");
            for (int i = 0; i < 8; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("---------------------------------" +
                            "------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("Conditions:");
                        Console.WriteLine();
                        Console.WriteLine("Prints:\t\t\t False ");
                        Console.WriteLine("Flashing light:\t\t True ");
                        Console.WriteLine("Printer recognized:\t False ");
                        Console.WriteLine();
                        Console.WriteLine("Possible Actions:");
                        PrinterCable();
                        PrinterSoftware();
                        CheckInk();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case 1:
                        Console.WriteLine("--------------------------------" +
                            "----------");
                        Console.WriteLine();
                        Console.WriteLine("Conditions:");
                        Console.WriteLine();
                        Console.WriteLine("Prints:\t\t\t False ");
                        Console.WriteLine("Flashing light:\t\t True ");
                        Console.WriteLine("Printer recognized:\t True ");
                        Console.WriteLine();
                        Console.WriteLine("Possible Actions:");
                        CheckInk();
                        PaperJam();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("-------------------------------" +
                            "-----------");
                        Console.WriteLine();
                        Console.WriteLine("Conditions:");
                        Console.WriteLine();
                        Console.WriteLine("Prints:\t\t\t False ");
                        Console.WriteLine("Flashing light:\t\t False ");
                        Console.WriteLine("Printer recognized:\t False ");
                        Console.WriteLine();
                        Console.WriteLine("Possible Actions:");
                        PowerCable();
                        PrinterCable();
                        PrinterSoftware();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("--------------------------------" +
                            "----------");
                        Console.WriteLine();
                        Console.WriteLine("Conditions:");
                        Console.WriteLine();
                        Console.WriteLine("Prints:\t\t\t False ");
                        Console.WriteLine("Flashing light:\t\t False ");
                        Console.WriteLine("Printer recognized:\t True ");
                        Console.WriteLine();
                        PaperJam();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("-----------------------------" +
                            "-------------");
                        Console.WriteLine();
                        Console.WriteLine("Conditions:");
                        Console.WriteLine();
                        Console.WriteLine("Prints:\t\t\t True ");
                        Console.WriteLine("Flashing light:\t\t True ");
                        Console.WriteLine("Printer recognized:\t False ");
                        Console.WriteLine();
                        PrinterSoftware();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("-------------------------------" +
                            "-----------");
                        Console.WriteLine();
                        Console.WriteLine("Conditions:");
                        Console.WriteLine();
                        Console.WriteLine("Prints:\t\t\t True ");
                        Console.WriteLine("Flashing light:\t\t True ");
                        Console.WriteLine("Printer recognized:\t True ");
                        Console.WriteLine();
                        CheckInk();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine("--------------------------------" +
                            "----------");
                        Console.WriteLine();
                        Console.WriteLine("Conditions:");
                        Console.WriteLine();
                        Console.WriteLine("Prints:\t\t\t True ");
                        Console.WriteLine("Flashing light:\t\t False ");
                        Console.WriteLine("Printer recognized:\t False ");
                        Console.WriteLine();
                        PrinterSoftware();
                        Console.WriteLine();
                        Console.WriteLine();                        
                        break;                    
                    default:
                        Console.WriteLine("---------------------------------" +
                            "---------");
                        Console.WriteLine();
                        Console.WriteLine("Conditions:");
                        Console.WriteLine();
                        Console.WriteLine("Prints:\t\t\t True ");
                        Console.WriteLine("Flashing light:\t\t False ");
                        Console.WriteLine("Printer recognized:\t True ");
                        Console.WriteLine();
                        Console.WriteLine("N/A");
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                }
            }
            #endregion
        }

        // methods for printing possible actions
        static void PowerCable()
        {
            Console.WriteLine(" - Check the power cable");
        }

        static void PrinterCable()
        {
            Console.WriteLine(" - Check the printer-computer cable");
        }

        static void PrinterSoftware()
        {
            Console.WriteLine(" - Ensure printer software is installed");
        }

        static void CheckInk()
        {
            Console.WriteLine(" - Check/replace ink");
        }

        static void PaperJam()
        {
            Console.WriteLine(" - Check for a paper jam");
        }
    }
}
