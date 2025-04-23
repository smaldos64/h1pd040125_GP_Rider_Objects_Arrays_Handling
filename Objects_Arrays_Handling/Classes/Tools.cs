namespace Objects_Arrays_Handling.Classes;

public class Tools
{
    // MakeEmptyLines har en default parameter værdi for EmptyLines
    // som er 1. Dette betyder, at hvis vi kalder EmptyLines uden et 
    // argument (EmptyLines() ) vil numerOfEmptyLines få tildelt værdien
    // 1 og vi vil få lavet én tom linje.
    public static void MakeEmptyLines(int numberOfEmptyLines = 1)
    {
        for (int counter = 0; counter < numberOfEmptyLines; counter++)
        {
            Console.WriteLine("");
        }
    }
}