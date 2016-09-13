using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace IfTester {
	internal class Test {
		Dictionary<string, TimeSpan> spans;
		public Dictionary<string, TimeSpan> Spans { get { return spans; } }
		int runs = 100000;

		Stopwatch sw;

		public Test( ) {
			spans = new Dictionary<string, TimeSpan>( );
		}

		public void Run( ) {
			sw = new Stopwatch( );
			sw.Start( );
			for ( int i = 0; i < runs; i++ ) {
				FallThrough( );
			}
			sw.Stop( );
			Console.WriteLine("Fallthrough: " +  sw.Elapsed );
			sw = new Stopwatch( );
			sw.Start( );

			for ( int i = 0; i < runs; i++ ) {

				NoFallThrough( );
			}
			sw.Stop( );
			Console.WriteLine( "NoFallthrough: " + sw.Elapsed );
		}

		private void FallThrough( ) {
			string match = "Nathan";
			if ( !( match == "Nathan" ) ) {
				//skip
			}
			else if ( !( match == "Bob" ) ) {
				//skip
			}
			else if ( !( match == "Jill" ) ) {
				//skip
			}
			else if ( match == "Nathan" ) {
				//still skip but we're timing here.
			}

		}

		private void NoFallThrough( ) {
			string match = "Nathan";
			if ( match == "Nathan" ) {
				//skip
			}
			else if ( match == "Bob" ) {
				//skip
			}
			else if ( match == "Jill" ) {
				//skip
			}
			else if ( match == "Kraig" ) {
				//still skip but we're timing here.
			}
		}

		private void FallThroughSwitch( ) {

		}

		private void NoFallThroughSwitch( ) {

		}
	}
}