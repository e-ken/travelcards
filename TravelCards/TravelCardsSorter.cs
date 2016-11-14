using System;
namespace TravelCards {
    public class TravelCardsSorter {
        /// <summary>
        /// Sort the specified cards.
        /// </summary>
        /// <param name="cards">Array of travel cards.</param>
        public TravelCard [] Sort (TravelCard [] cards) {
            int length = cards.Length;
            // Search from BEGIN to END
            for (int repeat = 1; repeat > 0; repeat--)
                for (int i = 0; i < length; i++) {
                    if (cards [0].From == cards [i].To) {
                        for (int n = i; n > 0; n--) // Shift <-
                            Exchange (cards, n, n - 1);
                        repeat++;
                    }
                }
            // Search from END to BEGIN
            for (int repeat = 1; repeat > 0; repeat--)
                for (int i = 0; i < length; i++) {
                    if (cards [i].From == cards [length - 1].To) {
                        for (int n = i; n < length - 1; n++) // Shift ->
                            Exchange (cards, n, n + 1);
                        repeat++;
                    }
                }
          
            return cards;
        }

        /// <summary>
        /// Exchange the specified cards, sourceIndex and destIndex.
        /// </summary>
        /// <param name="cards">Array of travel cards.</param>
        /// <param name="sourceIndex">Source index.</param>
        /// <param name="destIndex">Destination index.</param>
        private static void Exchange (TravelCard [] cards, int sourceIndex, int destIndex) {
            var tmp = cards [destIndex];
            cards [destIndex] = cards [sourceIndex];
            cards [sourceIndex] = tmp;
        }
    }
}
