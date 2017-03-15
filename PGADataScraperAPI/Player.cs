﻿using System;

namespace PGADataScaper.API
{
	public class Player {
		public string Last { get; private set; }
		public string First { get; private set; }
		public string ID { get; private set; }

		public Player(string l, string f, string i) {
			Last = l.Trim();
			First = f.Trim();
			ID = i;
		}

		public Player(string[] n, string i) {
			Last = n[0].Trim();
			First = n[1].Trim();
			ID = i;
		}

		public string FileName {
			get {
				return String.Format("{0}_{1}.json", Last.Replace(' ', '_'), First.Replace(' ', '_'));
			}
		}

		public string FullName {
			get {
				return String.Format("{0} {1}", First.Replace('-', ' '), Last);
			}
		}
	}
}
