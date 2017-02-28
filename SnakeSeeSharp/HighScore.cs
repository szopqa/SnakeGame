using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeSeeSharp {
	class HighScore {

		public int BestScore { get; set; }

		

		public HighScore () {

			try {
				Int32.TryParse(System.IO.File.ReadAllText("high_score.txt"), out BestScore);
			}
			System.IO.File.WriteAllText("high_score.txt", Settings.Score.ToString());
			


		}


	}
}
