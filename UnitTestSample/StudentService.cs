using System;

namespace UnitTestSample
{
    public class StudentService
    {
        /// <summary>
        /// 获取总的学生人数
        /// </summary>
        /// <returns></returns>
        public int GetStudentTotal()
        {
            return 100;
        }

        /// <summary>
        /// 根据班级名称获取平均分
        /// </summary>
        /// <param name="className"></param>
        /// <returns></returns>
        public decimal GetAvgScore(string className)
        {
            if (className == "一班")
            {
                return 73.5M;
            }
            else if (className == "二班")
            {
                return 79.3M;
            }
            else if (className == "三班")
            {
                return 81M;
            }
            else
            {
                throw new ArgumentOutOfRangeException("无效的班级");
            }
        }

    }
}
