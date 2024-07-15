// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

Console.WriteLine("Hello, World!");
ConsoleApp2.LRU LRUCache = new ConsoleApp2.LRU(new ConsoleApp2.Node(1), 10);

LRUCache.visit(2);
LRUCache.visit(3);
LRUCache.visit(4);
LRUCache.visit(5);
LRUCache.visit(6);
LRUCache.visit(7);
LRUCache.visit(8);
LRUCache.print();

LRUCache.visit(1);
LRUCache.print();

LRUCache.visit(9);

LRUCache.print();

LRUCache.visit(10);
LRUCache.visit(11);

LRUCache.print();




