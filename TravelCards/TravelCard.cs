using System;
namespace TravelCards {
    public class TravelCard {
        public string From { get; set; }
        public string To { get; set; }
        public override string ToString () {
            return string.Format ("{0}->{1}", From, To);
        }
    }
}
