using NUnit.Framework;
using System;
using TravelCards;

namespace TravelCardsTests {
    [TestFixture]
    public class TravelCardsTests {
        
        private TravelCard[][] unsortedCardsSource = new TravelCard [] [] {
            new TravelCard[] {
                new TravelCard { From = "Амстердам", To = "Рига" },
                new TravelCard { From = "Париж", To = "Амстердам" },
                new TravelCard { From = "Мельбурн", To = "Кельн" },
                new TravelCard { From = "Москва", To = "Париж" },
                new TravelCard { From = "Кельн", To = "Москва" }
            },
            new TravelCard[] {
                new TravelCard { From = "Амстердам", To = "Рига" },
                new TravelCard { From = "Мельбурн", To = "Кельн" },
                new TravelCard { From = "Москва", To = "Париж" },
                new TravelCard { From = "Париж", To = "Амстердам" },
                new TravelCard { From = "Кельн", To = "Москва" }
            },
            new TravelCard[] {
                new TravelCard { From = "Амстердам", To = "Рига" },
                new TravelCard { From = "Москва", To = "Париж" },
                new TravelCard { From = "Париж", To = "Амстердам" },
                new TravelCard { From = "Мельбурн", To = "Кельн" },
                new TravelCard { From = "Кельн", To = "Москва" }
            },
            new TravelCard[] {
                new TravelCard { From = "Москва", To = "Париж" },
                new TravelCard { From = "Париж", To = "Амстердам" },
                new TravelCard { From = "Мельбурн", To = "Кельн" },
                new TravelCard { From = "Кельн", To = "Москва" },
                new TravelCard { From = "Амстердам", To = "Рига" }
            },
            new TravelCard[] {
                new TravelCard { From = "Москва", To = "Париж" },
                new TravelCard { From = "Париж", To = "Амстердам" },
                new TravelCard { From = "Мельбурн", To = "Кельн" },
                new TravelCard { From = "Кельн", To = "Москва" },
                new TravelCard { From = "Рига", To = "Дюссельдорф" },
                new TravelCard { From = "Амстердам", To = "Рига" }
            },
            new TravelCard[] {
                new TravelCard { From = "Москва", To = "Париж" },
                new TravelCard { From = "Париж", To = "Амстердам" },
                new TravelCard { From = "Дюссельдорф", To = "Рязань" },
                new TravelCard { From = "Мельбурн", To = "Кельн" },
                new TravelCard { From = "Кельн", To = "Москва" },
                new TravelCard { From = "Рига", To = "Дюссельдорф" },
                new TravelCard { From = "Амстердам", To = "Рига" }
            },
            new TravelCard[] {
                new TravelCard { From = "Мельбурн", To = "Кельн" },
                new TravelCard { From = "Кельн", To = "Москва" },
                new TravelCard { From = "Москва", To = "Париж" },
                new TravelCard { From = "Париж", To = "Амстердам" },
                new TravelCard { From = "Дюссельдорф", To = "Рязань" },
                new TravelCard { From = "Амстердам", To = "Рига" },
                new TravelCard { From = "Рига", To = "Дюссельдорф" }
            }
        };

        [Test, TestCaseSource("unsortedCardsSource")]
        public void TravelCardsSorterTest_To_Equals_Next_From(TravelCard[] unsortedCards) {
            // Arrange
            var sorter = new TravelCardsSorter ();

            // Act
            var sortedCards = sorter.Sort (unsortedCards);

            bool result = true;
            for (int n = 1; n < sortedCards.Length; n++)
                result &= sortedCards [n - 1].To == sortedCards [n].From;

            // Assert
            Assert.IsTrue (result);
        }
    }
}
