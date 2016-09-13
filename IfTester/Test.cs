using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace IfTester {
	internal class Test {
		int runs = 100000000;
		Stopwatch sw;

		public void Run( ) {
			sw = new Stopwatch( );
			sw.Start( );
			for ( int i = 0; i < runs; i++ ) {
				FallThrough( i );
			}
			sw.Stop( );
			Console.WriteLine( "Fallthrough: " + sw.Elapsed );
			sw = new Stopwatch( );
			sw.Start( );

			for ( int i = 0; i < runs; i++ ) {

				NoFallThrough( i );
			}
			sw.Stop( );
			Console.WriteLine( "NoFallthrough: " + sw.Elapsed );
		}

		private void FallThrough( int i ) {
			if ( i == 0 ) {
				//skip
			}
			else if ( !( i == 0 ) ) {
				//skip
			}
		}

		private void NoFallThrough( int i ) {
			if ( !( i == 0 )) {
				//skip
			}
			else if ( i == 0 ) {
				//skip
			}
		}

		private void FallThroughSwitch( ) {

		}

		private void NoFallThroughSwitch( ) {

		}
	}
}