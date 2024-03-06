using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        List<string> likedBy = new List<string>();

        Console.WriteLine("Enter the names of people who liked your post (press Enter to finish):");

        while (true)
        {
            string input = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(input))
                break;

            likedBy.Add(input);
        }

        Console.WriteLine(GetLikeMessage(likedBy));
    }

    static string GetLikeMessage(List<string> likedBy)
    {
        int count = likedBy.Count;

        if (count == 0)
            return ""; // No one likes your post, don't display anything
        else if (count == 1)
            return likedBy[0] + " likes your post";
        else if (count == 2)
            return likedBy[0] + " and " + likedBy[1] + " like your post";
        else
        {
            Console.WriteLine("are we in the else block");
            StringBuilder sb = new StringBuilder();
            sb.Append(likedBy[0] + ", " + likedBy[1] + " and " + (count - 2) + " others like your post");
            return sb.ToString();
        }
    }
}
