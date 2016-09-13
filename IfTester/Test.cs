using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace IfTester {
	internal class Test {
		Stopwatch sw;

		public void Run(string s, int runs ) {
			sw = new Stopwatch( );
			sw.Start( );
			for ( int i = 0; i < runs; i++ ) {
				FallThrough( s );
			}
			sw.Stop( );
			Console.WriteLine( "Fallthrough: " + sw.Elapsed );
			sw = new Stopwatch( );
			sw.Start( );

			for ( int i = 0; i < runs; i++ ) {

				NoFallThrough( s );
			}
			sw.Stop( );
			Console.WriteLine( "NoFallthrough: " + sw.Elapsed );
		}

		private void FallThrough( string s ) {
			if ( s == "Nathan" ) {
				//skip
			}
			else if ( !( s == "Nathan" ) ) {
				//skip
			}
		}

		private void NoFallThrough( string s ) {
			if ( !( s == "Nathan" )) {
				//skip
			}
			else if ( s == "Nathan" ) {
				//skip
			}
		}

		private void FallThroughSwitch( ) {

		}

		private void NoFallThroughSwitch( ) {

		}
	}
}