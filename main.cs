using System;

class MainClass {
  public static void Main (string[] args) {
    int val1 = 0;
		string op = ""; //def vars
		int val2 = 0;
		int ans = 0;
		Console.WriteLine("Number 1");
		string temp =  Console.ReadLine();
		val1 = int.Parse(temp); //string to num
		Console.WriteLine("what do you want to do? \n multiply=* \n div = / \n sub = - \n add = + \n mod = mod");
		op= Console.ReadLine();
		Console.WriteLine("Number 2");
		 temp =  Console.ReadLine();
		val2 = int.Parse(temp); //string to num
		if (op == "+"){				//finds what to do
			 ans = val1+val2;} 	//does it 
		if (op == "-"){				//repeat
			 ans = val1-val2;}
		if (op == "/"){
			 ans = val1/val2;}
		if (op == "*"){
			 ans = val1*val2;}
		if (op == "mod"){
			 ans = val1 % val2;}
		Console.WriteLine(ans);
  }
}