using StudentGrades;

namespace PercentageTesting
{
    public class Tests
    {

        private GradeCalculator _gradeCalculator { get; set; } = null!;

        [SetUp]
        public void Setup()
        {
            _gradeCalculator = new GradeCalculator();
        }

        [TestCase(95)]
        [TestCase(97)]
        [TestCase(98)]
        public void Test1(int percentage)
        {

            // var percent = 90;

            var grade = _gradeCalculator.GetGradeByPercentage(percentage);
            Assert.That(grade, Is.EqualTo("A"));


        }

        [TestCase(50)]
        [TestCase(70)]
        public void Test2(int percentage)
        {

            // var percent = 90;

            var grade = _gradeCalculator.GetGradeByPercentage(percentage);
            Assert.That(grade, Is.EqualTo("F"));


        }
    }
}