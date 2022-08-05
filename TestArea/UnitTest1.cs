using AreaFigureDLL;

namespace TestArea
{
    public class Tests
    {
        // �������� �� ������������� ��������
        [Test]
        public void TestNegativeValueCircle()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new AreaCircle(-10));
        }
        [Test]
        public void TestNegativeValueTriangle()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new AreaTriangle(5, -10, 6));
            Assert.Throws<ArgumentOutOfRangeException>(() => new AreaTriangle(-5, -10, -6));
            Assert.Throws<ArgumentOutOfRangeException>(() => new AreaTriangle(5, 10, -6));
        }

        // �������� �� ���������� �������
        [Test]
        public void TestAreaCircle()
        {
            Assert.That(new AreaCircle(6).AreaFig(), Is.EqualTo(113.09733552923255));
        }
        [Test]
        public void TestAreaTriangle()
        {
            Assert.That(new AreaTriangle(3, 4, 5).AreaFig(), Is.EqualTo(6));
        }

        // �������� �� ��������������� ������������
        [Test]
        public void TestRightTriangle()
        {
            Assert.That(new AreaTriangle(5, 3, 4).IsRect, Is.EqualTo(true));
        }
    }
}