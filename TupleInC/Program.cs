using System;

namespace TupleInC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            // Khởi tạo Tuple thông qua phương thức Create
            var MyTuple = Tuple.Create<int, string>(1, "Loc");
           
            // Khởi tạo Tuple thông qua constructor của các lớp generic
            var MyTuple2 = new Tuple<int, string>(2, "Thanh");
            
            // Lấy giá trị bên trong Tuple
            //Console.WriteLine(" ID: {0}, Name: {1}", MyTuple2.Item1, MyTuple2.Item2);
            #endregion

            #region
            /// <summary>
            /// Phương thức trả về 1 Tuple có 3 thuộc tính (cả 3 đều có kiểu dữ liệu là int)
            /// </summary>
            /// <returns></returns>

            static Tuple<int, int, int> GetCurrentDayMonthYear()
            {
                DateTime now = DateTime.Now; // lấy ngày giờ hiện tại của hệ thống.
                /* Sử dụng Constructor của Tuple<> để trả về hoặc có thể sử dụng phương thức Create đã trình bày ở trên. */
                return new Tuple<int, int, int>(now.Day, now.Month, now.Year);
            }
            /*
            * dùng var để C# tự nhận diện kiểu dữ liệu.
            * có thể khai báo tường minh kiểu dữ liệu là Tuple<int, int, int>
            */

            var now = GetCurrentDayMonthYear();
            Console.WriteLine(" Day: {0}, Month: {1}, Year: {2}", now.Item1, now.Item2, now.Item3);
            #endregion


        }
    }
}
