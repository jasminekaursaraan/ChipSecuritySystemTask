using System;
using System.Collections.Generic;

using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChipSecuritySystem
{
    public class Program
    {
        //ChipsAreLinked accepts a list of tuples where each tuple represents a chip.
        //with two strings representing its starting and ending colors.
        //The method returns a boolean indicating whether the chips are linked or not.
        //Why are we using List Tuple?
        //Using a list of tuples allows you to maintain the sequence of chips
        //while associating each chip with its starting and ending colors.It
        //provides a structured way to organize the data and enables easy access
        //to individual chips and their colors within the code.
        //In this case, the algorithm iterates through the list of chips
        //and checks if the ending color of each chip matches the starting color
        //of the next chip. 

        public static bool ChipsAreLinked(List<Tuple<string, string>> chips)
        {
            if (chips.Count == 0)
                return false;

            // we are defining starting and ending markers
            string startMarker = "Blue";
            string endMarker = "Green";
            // Check if the first chip's starting color is BLUE
            if (chips[0].Item1 != startMarker)
                return false;

            // Check if the last chip's ending color is GREEN
            if (chips[chips.Count - 1].Item2 != endMarker)
                return false;
            //below we are looping thru all the chips except the last chip
            for (int i = 0; i < chips.Count - 1; i++)
            {
                // Check if the ending color of the current chip matches
                // the starting color of the next chip
                if (chips[i].Item2 != chips[i + 1].Item1)
                    return false;
            }
            //if all above conditions are met, chips are linked.
            return true;
        }

        static void Main(string[] args)
        {
           //hardcoded the list of chips provided in task below, we can change the sample scenarios.
            List<Tuple<string, string>> chips = new List<Tuple<string, string>>
                 {
            Tuple.Create("Blue", "Yellow"),
            Tuple.Create("Yellow", "Red"),
            Tuple.Create("Red", "Green"),
            Tuple.Create("Orange", "Purple")

        };
            Console.WriteLine(ChipsAreLinked(chips) ? "Chips can link from end to end." : "Chips cannot link from end to end.");
        }
    }
}

/* Time Complexity Of DFS:
 * depends on data structure used to represent graph and the way algorithm is implemented
 * in dfs, you start at a given vertex and explore as far as possible along each branch before backtracking
 * this mean each vertex and edge is visited once in worst case
 * lets assume:
 * V = # of vertices
 * E = # of edges
 * in works case scenario, DFS visits every vertex and edges in graph. 
 * each vertex is visited once, for each visited vertex all its edges are explored
 * 1. Visited each vertex O(V)
 * 2. Visited each edge O(E)
 * Thus overall time complexity - O(V+E)
 * This time complexity arise because DFS traversing graph, exploring all reachable vertices and edges from starting vertex
 * in worst case, it may visit every vertex and edge in graph once.
 * It is important to note that time complexity of DF is proportional to size of graph
 * (vertices and edges) rather than shape or structure of graph.
*/






