// See https://aka.ms/new-console-template for more information
using LinkedList_Implementation_Solution;

Console.WriteLine("Hello, World!");

OurNode first = new OurNode("First");
OurNode second = new OurNode("Second");
OurNode third = new OurNode("Third");

OurLinkedList oll = new OurLinkedList(new List<OurNode> { first, second, third});

Console.WriteLine(oll.Head.Info);
//Console.WriteLine(oll.Head.Next.Info);