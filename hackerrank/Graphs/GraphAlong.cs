using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HackerRank.Graphs
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

		public Dictionary<string, List<string>> hasPath = new()
		{
			{"f", new List<string>() {"g", "i"}},
			{"g", new List<string>() {"h"}},
			{"h", new List<string>() { }},
			{"i", new List<string>() {"g", "k"}},
			{"j", new List<string>() {"i"}},
			{"k", new List<string>() {}},
		};

		public Dictionary<string, List<string>> edgeNode = new()
		{
			{"i", new List<string>() {"j", "k"}},
			{"j", new List<string>() {"i"}},
			{"k", new List<string>() {"i", "l", "m"}},
			{"l", new List<string>() {"k"}},
			{"m", new List<string>() {"K"}},
			{"n", new List<string>() {"o"}},
			{"o", new List<string>() {"n"}}
		};

		public GraphAlong()
		{
		}

		public void DepthFirstSearch(string node)
		{
			var stack = new Stack<string>();
			stack.Push(node);
			while (stack.Count > 0)
			{
				var current = stack.Pop();
				Console.Write($"{current} ");
				foreach(var item in graphs[current])
				{
					stack.Push(item);
				}
			}
		}

		public void BreadthFirstSearch(string node)
		{
			var queue = new Queue<string>();
			queue.Enqueue(node);
			while(queue.Count > 0)
			{
				var current = queue.Dequeue();
				Console.Write($"{current} ");
				foreach(var item in graphs[current])
				{
					queue.Enqueue(item);
				}
			}
		}

		public void RecursiveDepthFirstSearch(string node)
		{
			Console.Write($"{node} ");
			foreach(string item in graphs[node])
			{
				RecursiveDepthFirstSearch(item);
			}
		}

		public bool HasPathDFS(string src, string dest)
		{
			if(src == dest)
				return true;
			foreach(string item in hasPath[src])
			{
				if(HasPathDFS(item, dest) == true)
				{
					return true;
				}
			}
			return false;
		}

		public bool HasPathBFS(string src, string dest)
		{
			var queue = new Queue<string>();
			queue.Enqueue(src);
			while(queue.Count > 0)
			{
				var current = queue.Dequeue();
				if(current == dest)
				{
					return true;
				}
				foreach(var item in hasPath[current])
				{
					queue.Enqueue(item);
				}
			}
			return false;
		}

		public bool EdgeNodeHasPathDFS(string src, string dest)
		{
			var stack = new Stack<Tuple<string, bool>>();
			stack.Push(new Tuple<string, bool>(src, false));
			while(stack.Count > 0)
			{
				var current = stack.Pop();
				foreach(var tup in edgeNode[current.Item1])
				{
					var node = new Tuple<string, bool>(tup, true);
					if(node.Item1 == dest)
					{
						return true;
					}
					stack.Push(node);
					if(current.Item2 == true) 
					{
						stack.Pop();
					}
				}
			}
			return false;
		}
	}
}
