using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrankbullshit.Graphs
{
	/// <summary>
	/// code along with https://www.youtube.com/watch?v=tWVWeAqZ0WU&t=1382s
	/// </summary>
	public class GraphAlong
	{
		public Dictionary<string, List<string>> graphs = new()
		{
			{"a", new List<string>() { "c", "b" }},
			{"b", new List<string>() { "d" }},
			{"c", new List<string>() { "e" }},
			{"d", new List<string>() { "f" }},
			{"e", new List<string>() {}},
			{"f", new List<string>() {}}
		};

		public GraphAlong()
		{
			DepthFirstSearch(graphs, "a");
		}

		public void DepthFirstSearch(Dictionary<string, List<string>> graph, string node)
		{
			var stack = new Stack<string>() { };
			stack.Push(node);
			while (stack.Count > 0)
			{
				var current = stack.Pop();
				Console.WriteLine(current);
				foreach(var item in graphs[current])
				{
					stack.Push(item);
				}

			}
		}

		public void BreadthFirstSearch()
		{

		}

		public void RecursiveDepthFirstSearch()
		{

		}

		public void RecursiveBredthFirstSearch()
		{

		}
	}
}
