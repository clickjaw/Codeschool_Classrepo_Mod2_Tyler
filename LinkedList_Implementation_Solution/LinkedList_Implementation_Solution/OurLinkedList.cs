using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Implementation_Solution
{
	public class OurLinkedList
	{
		public OurNode Head { get; set; }
		
		public OurLinkedList() {
			Head = new OurNode();

		}
		public OurLinkedList(List<OurNode> nodes)
		{
			Head = new OurNode();
			//Add All implementation
			
		}

		public void AddFirst (OurNode node) {
			Head = node;
			
		}

		public void AddLast(OurNode node)
		{

			if (Head.Next == null)
			{
				Head.Next = node;
			}
			else
			{
				OurNode Current = Head;
				while (Current.Next != null)
				{
					Current = Current.Next;
				}
				Current.Next = node;
			}
		}


	}

	public class OurNode
	{
		public string Info { get; set; }
		public OurNode Next { get; set; }
		//OurNode Prev;
		public OurNode()
		{
			Info = "";
			Next = null;
		}
		public OurNode(string info)
		{
			Info = info;
			Next = null;
		}
		public OurNode(string info, OurNode next)
		{
			Info = info;
			Next = next;
		}
	}
}
