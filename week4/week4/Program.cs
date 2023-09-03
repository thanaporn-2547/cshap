// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;



    string[] std = {
        "663245001","663245002","663245003","663245004","663245005","663245006","663245009","664245025"
    };

string[] prefix = {
    "Mr.", "Mr.", "Mr.", "Mr.", "Mr.", "Ms.", "Mr.", "Ms."
};

string[] name = {
    "Kittiphong", "Tanakorn", "Pongsakon", "Watcharapong", "Intnt", "Kannikar", "Kitisak", "Thanaporn"
};

string[] Lastname = {
    "Chaimon", "Suphaphut", "Kongnoi", "Mameengam", "Kanalaksombat", "Patposri", "Srisuk", "Hongngam"
};

int i = 0;
int seq = 0;
while (i < 8)
{
    seq++;
    Console.WriteLine(seq + "." + std[i] + " " + prefix[i] + name[i] + " " + Lastname[i]);
    i++;
}

Console.WriteLine("press any key to close");
Console.ReadLine();