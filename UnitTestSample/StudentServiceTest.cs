using System;
using Xunit;

namespace UnitTestSample
{
    public class StudentServiceTest
    {
        [Fact]
        public void GetStudentTotal_Test()
        {
            var studentService = new StudentService();
            var total = studentService.GetStudentTotal();
            Assert.Equal(100, total);
        }

        [Fact]
        public void GetAvgScore_Test()
        {
            var studentService = new StudentService();
            var score1 = studentService.GetAvgScore("一班");
            Assert.Equal(73.5M, score1);

            var score2 = studentService.GetAvgScore("二班");
            Assert.Equal(79.3M, score2);

            var score3 = studentService.GetAvgScore("三班");
            Assert.Equal(81M, score3);

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                return studentService.GetAvgScore("四班");
            });
        }

    }
}
