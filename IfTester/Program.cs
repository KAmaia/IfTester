using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfTester {
	class Program {
		static void Main( string[ ] args ) {
			Test t = new Test();
			for ( int i = 0; i < 10; i++ ) {
				t.Run( );
			}
			Console.WriteLine( "Press Any Key" );
			Console.ReadKey( );
		}
	}
}
