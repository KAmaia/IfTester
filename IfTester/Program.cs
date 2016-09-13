using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfTester {
	class Program {

		static void Main( string[ ] args ) {
			string name = args[0];
			int runs = 1000;
			Console.WriteLine( "If Tester, Test String = " + name +  " Runs: " + runs);
			for ( int i = 0; i < 10; i++ ) {
				Console.WriteLine( "Test " + i );
				Test t = new Test();
				t.Run( args[0], runs );
				Console.WriteLine( "====" );
			}
			Console.WriteLine( "Press Any Key" );
			Console.ReadKey( );
		}
	}
}