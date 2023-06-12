// See https://aka.ms/new-console-template for more information
using System;

int val = 12345;
int firstVal = val / 10000; //1
int secondVal = val / 1000 - firstVal * 10; // 2
int thirdVal = val / 100 - (firstVal * 100 + secondVal * 10); // 3
int fourthVal = val / 10 - (firstVal * 1000 + secondVal * 100 + thirdVal * 10); // 4
int fifthVal = val - (firstVal * 10000 + secondVal * 1000 + thirdVal * 100 + fourthVal * 10); // 5

Console.WriteLine(firstVal);
Console.WriteLine(secondVal);
Console.WriteLine(thirdVal);
Console.WriteLine(fourthVal);
Console.WriteLine(fifthVal);