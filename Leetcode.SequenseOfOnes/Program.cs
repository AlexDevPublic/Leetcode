using System;
using System.IO;

class Program
{
    static void Main()
    {
        
    }
}

using var stream = new FileStream("input.txt", FileMode.Open);
using var streamReader = new StreamReader(stream);

var countOfNumbers = int.Parse(streamReader.ReadLine());

var sequense = new int [countOfNumbers];
var currentLine = 0;
do
{
     sequense[currentLine] = int.Parse(streamReader.ReadLine());
     currentLine++;
} while (!streamReader.EndOfStream);

var maxSequenseCount = 0;
var currentSequenseMatches = 0;
for (var i = 0; i < sequense.Length; i++)
{
    if (sequense[i] == 1)
    {
        currentSequenseMatches++;
    }
    
    else
    {
        currentSequenseMatches = 0;
    }

    if (currentSequenseMatches > maxSequenseCount)
    {
        maxSequenseCount = currentSequenseMatches;
    }
}
using var outputStream = new FileStream("output.txt", FileMode.OpenOrCreate);
using var outputStreamWriter = new StreamWriter(outputStream);
outputStreamWriter.WriteLine(maxSequenseCount);