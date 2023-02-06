using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Library_jan;

namespace Library_jan_Test
{
    //Использвуется структура AAA.
    //---------------------
    //Arrange    Подготовка
    //Act        Действие
    //Assert     Проверка
    //---------------------

    //Тестирование треугольника.
    [TestClass]
    public class TriangleTests
    {
        //Возвращает True если треугольник прямоугольный.
        [TestMethod]
        public void ifStraightReturnTrue()
        {
            var triangle = new Triangle("Треугольник", 3, 4, 5);

            var result = triangle.isStraightTriangle();

            Assert.IsTrue(result);
        }

        //Площадь треугольника со сторонами 3,4,5 = 6. Если ожидаемый и фактический результаты не совпали, создается исключение.
        [TestMethod]
        public void Square3_4_5Return6()
        {
            var triangle = new Triangle("Треугольник", 3, 4, 5);
            double expected = 6;

            var result = triangle.Square();

            Assert.AreEqual(expected, result);
        }
    }

    //Тестирование Круга.
    [TestClass]
    public class CircleTest
    {
        //Площадь круга с радиусом 10 = 314.2. Если ожидаемый и фактический результаты не совпали, создается исключение.
        [TestMethod]
        public void Square10Return314_2()
        {
            var circle = new Circle("Круг", 10);
            double expected = 314.2;

            var result = circle.Square();

            Assert.AreEqual(expected, result);
        }
    }
}
