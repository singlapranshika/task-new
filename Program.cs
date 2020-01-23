using System;
using System.IO;
namespace ConsoleApp1
{
	class Feedback
	{
		/// <summary>
		/// This class contains methods to generate feedback of new hiree 
		/// </summary>
		String name, designation;
		String feedb;
		Feedback(String n, String d)
		{
			///<summary>
			///This is a Parameterized Constructor of Feedback class 
			///</summary>
			name = n;
			designation = d;
		}
		
		public String FeedbackIntern()
		{
			///<summary>
			///This is a <c>Feedback</c> class Function
			///<returns>
			///string feedback of intern
			///</returns>
			///<remarks>
			///<para>This function records the feedback of an intern</para>
			///</remarks>
			///</summary>
			feedb = Console.ReadLine();
			return feedb;
		}
		public String FeedbackFTE()
		{
			///<summary>
			///This is a Feedback class function
			///<returns>
			///string feedback of FTE
			///</returns>
			///<remarks>
			///This function records the feedback of FTE
			///</remarks>
			///</summary>
			feedb = Console.ReadLine();
			return feedb;
		}
		class Program
		{   
			///<summary>
			///This is the <c>Main</c> method
			///</summary>
			static void Main(string[] args)
			{
			
				String n, d, f = "";
				Console.WriteLine("enter name and designation");
				n = Console.ReadLine();
				d = Console.ReadLine();
				Feedback feed = new Feedback(n,d);
				Console.Write("enter feedback");
				if (feed.designation == "intern")
				{
					f = feed.FeedbackIntern();
				}
				else if (feed.designation == "fte")
				{
					f = feed.FeedbackFTE();
				}
				Console.WriteLine(feed.designation + "'s feedback is * " + f+"*");

			}
		}
	}
}
